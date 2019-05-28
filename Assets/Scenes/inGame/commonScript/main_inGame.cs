using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class main_inGame : MonoBehaviour
{
    // Start is called before the first frame update
    UiData pauseMenu;

    public ButtonData pauseButton;
    public ButtonData resumeButton;
    public ButtonData exitButton;

    private AudioSource sound;
    void Start()
    {
        new screenSetting().screenSet();
        pauseMenu = new UiData("picturePause");
        pauseButton = new ButtonData("pause");
        resumeButton = new ButtonData("resume");
        exitButton = new ButtonData("exit");

        pauseMenu.disable();
        pauseButton.enable();
        resumeButton.disable();
        exitButton.disable();

        sound = GameObject.Find("music").GetComponent<AudioSource>();
        sound.clip = Resources.Load<AudioClip>(commonData.path + "/music/" + commonData.musicName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || pauseButton.isClicked == true)
        {
            if (pauseMenu.buttonShow.enabled == false)
                GamePause();
        }
        if (pauseMenu.buttonShow.enabled == true)
        {
            if (resumeButton.isClicked == true)
                GameResume();
            if (exitButton.isClicked == true)
                UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
        }
    }

    public void GamePause()
    {
        Time.timeScale = 0;
        pauseMenu.enable();
        pauseButton.disable();
        resumeButton.enable();
        exitButton.enable();

        sound.Pause();
    }

    public void GameResume()
    {
        Time.timeScale = 1;
        pauseMenu.disable();
        pauseButton.enable();
        resumeButton.disable();
        exitButton.disable();

        sound.Play();
    }
}
