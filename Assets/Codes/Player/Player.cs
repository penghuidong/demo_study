using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            float horizontal = Input.GetAxis("Horizontal"); // AD左右
            float vertical = Input.GetAxis("Vertical");  //  WS上下

            transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
            transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        }
    }
}
