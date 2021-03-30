using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float speed = 7.0f;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            Debug.Log("player is null");
            return;
        }

        float mx = Input.GetAxis("Mouse X");
        float my =  -Input.GetAxis("Mouse Y");   // 这里为啥要去负

        if ( Input.GetKey(KeyCode.Mouse1) )
        {
            transform.Translate(Vector3.left * speed * mx * Time.deltaTime);
            transform.Translate(Vector3.up * speed * my * Time.deltaTime);
        }

        if ( Input.GetKey(KeyCode.Mouse0) )
        {
            transform.RotateAround(player.transform.position, Vector3.up, mx * speed);
            transform.RotateAround(player.transform.position, transform.right, my * speed);
        }
    }
}
