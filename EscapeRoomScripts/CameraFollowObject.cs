using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    public Transform targetObject;
    public Vector3 initialOffset;
    public Vector3 cameraPosition;
    // Update is called once per frame

    public void Start()
    {
        initialOffset = transform.position - targetObject.position;
    }


    public void Update()
    {
        cameraPosition = targetObject.position + initialOffset;
        transform.position = cameraPosition;
    }
}
