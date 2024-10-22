﻿using UnityEngine;
using System.IO;

public class main_startScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        new screenSetting().screenSet();
        TextAsset asset = Resources.Load("PlayerInfo") as TextAsset;
        userDataIO.readData();
    }

    // Update is called once per frame
    private void Update()
    {
        //if (Application.platform == RuntimePlatform.Android)
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }
    void FixedUpdate()
    {
        if(Time.time > 1)
            if (Input.touchCount > 0)
                UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
