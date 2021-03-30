using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Networking;

public class UGUI_Button : MonoBehaviour
{
    private Button testBtn;

    // 静态调用
    public void OnClickTest()
    {
        Debug.Log("damonpeng UGUI Button Click Test");
    }
    
    public void Start()
    {
        // 脚本动态调用
        GameObject obj = GameObject.Find("Button");
        if (obj != null)
        {
            testBtn = obj.GetComponent<Button>();
            if (testBtn != null)
            {
                testBtn.onClick.AddListener(OnClickTest);
                testBtn.onClick.AddListener(() => OnClickMy("lambda"));
                testBtn.onClick.AddListener(delegate { OnClickMy("delegate"); });
            }
        }
    }

    private void OnClickMy(string arg)
    {
        Debug.Log(arg);
    }
}
