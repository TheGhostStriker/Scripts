using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectiveMode : MonoBehaviour
{
    public float finalSize = 10f;
    public float increaseSpeed = 0.1f;
    public float returnSpeed = 0.2f;
    public float returnDelay = 2f;
    public int maxResource = 50;
    public int currentResource;
    public ResourceBar resourceBar;
    public BoxCollider b_collider;

    private bool isExpanding = false;
    private bool canPressP = true;
    private float returnTimer = 0f;
    private float resourceRegenRate = 1f; // resource regenerated per second
    private float resourceRegenTimer = 0f;

    public GameObject TerrainScannerPrefab;
    public float duration = 10;
    public float size = 500;

    private void Start()
    {
        currentResource = maxResource;
        resourceBar.SetMaxResource(maxResource);
    }

    private void Update()
    {
        // Check if the P key can be pressed again
        if (!canPressP && b_collider.size.x <= 1f && b_collider.size.z <= 1f)
        {
            canPressP = true;
        }

        // Check if the P key is pressed and the box can expand
        if (Input.GetKeyDown(KeyCode.P) && canPressP && currentResource > 10)
        {
            isExpanding = true;
            canPressP = false;
            LoseResource(10);
            SpawnTerrainScanner();
        }

        // Check if the box collider is still expanding
        if (isExpanding && b_collider.size.x < finalSize && b_collider.size.z < finalSize)
        {
            // Increase the size of the box collider
            b_collider.size += new Vector3(increaseSpeed, 0, increaseSpeed);

            // Reset the return timer while the collider is still expanding
            returnTimer = 0f;
        }
        else
        {
            isExpanding = false;

            // Increment the return timer when the collider is not expanding
            returnTimer += Time.deltaTime;

            // Check if the return timer has exceeded the delay
            if (returnTimer >= returnDelay)
            {
                // Shrink the box collider back to its original size
                b_collider.size -= new Vector3(returnSpeed, 0, returnSpeed);

                // Clamp the collider size to its original size to avoid overshooting
                if (b_collider.size.x < 1f || b_collider.size.z < 1f)
                {
                    b_collider.size = Vector3.one;
                }
            }
        }

        // Regenerate the resource over time
        resourceRegenTimer += Time.deltaTime;
        if (resourceRegenTimer >= 1f / resourceRegenRate)
        {
            resourceRegenTimer = 0f;
            GainResource(1);
        }
    }

    public void LoseResource(int resource)
    {
        currentResource -= resource;
        resourceBar.SetResource(currentResource);

        if (currentResource <= 0)
        {
            currentResource = 0;
            canPressP = false;
        }
    }

    public void GainResource(int resource)
    {
        currentResource += resource;

        if (currentResource > maxResource)
        {
            currentResource = maxResource;
        }

        resourceBar.SetResource(currentResource);
    }

    private void SpawnTerrainScanner()
    {
        GameObject terrainScanner = Instantiate(TerrainScannerPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        ParticleSystem terrainScannerPS = terrainScanner.transform.GetChild(0).GetComponent<ParticleSystem>();

        if(terrainScannerPS != null)
        {
            var main = terrainScannerPS.main; 
            main.startLifetime = duration;
            main.startSize = size;
        }
        else

        Destroy(terrainScanner, duration+1);
    }
}






