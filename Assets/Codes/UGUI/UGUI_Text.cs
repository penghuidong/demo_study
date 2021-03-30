using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UGUI_Text : MonoBehaviour
{
    private Text TestText;
    // Start is called before the first frame update
    void Start()
    {
        TestText = GameObject.Find("Canvas/Text").GetComponent<Text>();
        if (TestText != null)
        {
            TestText.fontSize = 160;
            TestText.fontStyle = FontStyle.Normal;
            TestText.color = Color.red;
            TestText.text = "hello unity ugui text";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
