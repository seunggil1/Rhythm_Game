using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class main_inGame : MonoBehaviour
{
    // Start is called before the first frame update
    UiData pauseMenu;

    public ButtonData pauseButton;
    public ButtonData resumeButton;
    public ButtonData exitButton;

    private Text score;
    private Text combo;
    private AudioSource sound;
    void Start()
    {
        new screenSetting().screenSet(1920);
        pauseMenu = new UiData("picturePause");
        pauseButton = new ButtonData("pause");
        resumeButton = new ButtonData("resume");
        exitButton = new ButtonData("exit");

        pauseMenu.disable();
        pauseButton.enable();
     
        resumeButton.disable();
        exitButton.disable();

        sound = GameObject.Find("music").GetComponent<AudioSource>();
        sound.clip = Resources.Load<AudioClip>(commonData.path + "/music/" + commonData.musicName) as AudioClip;

        score = GameObject.Find("score").GetComponent<Text>();
        combo = GameObject.Find("combo").GetComponent<Text>();
        commonData.score = 0;
        commonData.combo = 0;

        sound.Play();
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
            {
                GameResume();
                UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
            }
                
        }
        string num = commonData.score.ToString();
        string result= "score : ";
        for (int i = 0; i < 10 - num.Length; i++)
            result += "0";
        result += num;
        score.text = result;

        if (commonData.combo == 0)
            combo.text = "";
        else
            combo.text = commonData.combo.ToString();
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
