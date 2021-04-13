using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Start");
        var netManager = GetComponent<NetworkManager>();
        if ( netManager != null )
        {
            netManager.playerPrefab = null;
        }
        else
        {
            Debug.Log("NetworkManager Is Null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // AD左右
        float vertical = Input.GetAxis("Vertical");  //  WS上下

        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }
}
