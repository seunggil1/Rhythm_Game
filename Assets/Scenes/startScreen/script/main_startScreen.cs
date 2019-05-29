using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class main_startScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //해상도 설정, 가로 회전만 가능
        Screen.SetResolution(1280, 720, true);
        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
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
        if (Input.touchCount > 0)
            UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
