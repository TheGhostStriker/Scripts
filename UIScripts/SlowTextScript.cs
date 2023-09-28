using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SlowTextScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textMeshPro;
    [SerializeField] float timeBetweenCharacters;
    [SerializeField] float timeBetweenWords;

    public GameObject endGameButton;

    int i = 0;

    public string[] stringArray;

    private void Start()
    {
        Invoke("EndGame", 20f);
        EndCheck();
    }

    void EndCheck()
    {
        if(i <= stringArray.Length - 1)
        {
            _textMeshPro.text = stringArray[i];
            StartCoroutine(TextVisible());
        }
    }

    private IEnumerator TextVisible()
    {
        _textMeshPro.ForceMeshUpdate();
        int totalVisibleCharacters = _textMeshPro.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            _textMeshPro.maxVisibleCharacters = visibleCount;

            if(visibleCount >= totalVisibleCharacters)
            {
                i += 1;
                Invoke("EndCheck", timeBetweenWords);
                break;
                   
            }

            counter += 1;
            yield return new WaitForSeconds(timeBetweenCharacters);
        }
    }

    void EndGame()
    {
        endGameButton.SetActive(true);
    }

}
