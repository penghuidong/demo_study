using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public float updateInterval = 0.5f;
    
    private float accum = 0;

    private int frames = 0;

    private float timeleft = 0;

    private string stringFPS;

    void Start()
    {
        timeleft = updateInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;
        if ( timeleft <= 0.0f )
        {
            float fps = accum / frames;
            stringFPS = System.String.Format("{0:F2} FPS", fps);
            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }

    private void OnGUI()
    {
        GUIStyle guiStyle = GUIStyle.none;
        guiStyle.fontSize = 30;
        guiStyle.normal.textColor = Color.red;
        guiStyle.alignment = TextAnchor.UpperLeft;
        Rect rt = new Rect(40, 0, 100, 100);
        GUI.Label(rt, stringFPS, guiStyle);
    }
}
