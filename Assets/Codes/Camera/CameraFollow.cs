using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraFollow : NetworkBehaviour
{
    public Transform playerTransform;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;
        transform.position = playerTransform.position + offset;
    }
}
