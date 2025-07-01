using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraBackground : MonoBehaviour
{
    public Transform cameraTransform;

    void Update()
    {
        transform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, transform.position.z);
    }
}

