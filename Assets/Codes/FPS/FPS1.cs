using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS1 : MonoBehaviour
{
    private float showInterval = 0.5f;
    private int frames = 0;
    private float postTime = 0f;
    private string fps;

    private Text Test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        postTime += Time.deltaTime;
        if ( postTime >= showInterval )
        {
            fps = System.String.Format("{0:F1} ", frames / postTime);
            frames = 0;
            postTime = 0;
        }
    }

    private void OnGUI()
    {
        GUIStyle gui = GUIStyle.none;
        gui.fontSize = 30;
        gui.normal.textColor = Color.red;
        gui.alignment = TextAnchor.UpperLeft;
        GUI.Label(new Rect(10, 1, 100, 100), fps, gui);
    }
}
