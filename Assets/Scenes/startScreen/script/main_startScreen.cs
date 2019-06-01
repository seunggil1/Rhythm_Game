using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class main_startScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        new screenSetting().screenSet();

    }

    // Update is called once per frame
    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
            if (Input.GetKey(KeyCode.Escape))
                Application.Quit();
    }
    void FixedUpdate()
    {
        if(Time.time > 1.5)
            if (Input.touchCount > 0)
                UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
