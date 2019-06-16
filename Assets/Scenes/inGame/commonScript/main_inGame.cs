using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Diagnostics;

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

    Stopwatch sw;
    
    void Start()
    {
        new screenSetting().screenSet(1920); //1920*1080
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

        commonData.clear();

        pauseMenu.buttonShow.sprite = Resources.Load<Sprite>(commonData.path + "/sprite/background/[1280_720]pauseMenu") as Sprite;
        sound.Play();

        switch (commonData.path[commonData.path.Length - 1])
        {
            case '1':
                score.color = Color.white;
                combo.color = Color.white;
                break;
            case '2':
                score.color = Color.white;
                combo.color = Color.gray;
                break;
            case '3':
                score.color = Color.blue;
                combo.color = Color.blue;
                break;
        }
        sw = new Stopwatch();
        sw.Start();

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
            combo.text = "Combo\n"+commonData.combo.ToString();

        if(sound.clip.length +3.0f < sw.ElapsedMilliseconds * 0.001f)
        {
            sw.Stop();
            UnityEngine.SceneManagement.SceneManager.LoadScene("result");
        }
    }

    public void GamePause()
    {
        Time.timeScale = 0;
        pauseMenu.enable();
        pauseButton.disable();
        resumeButton.enable();
        exitButton.enable();

        sw.Stop();
        sound.Pause();
    }

    public void GameResume()
    {
        Time.timeScale = 1;
        pauseMenu.disable();
        pauseButton.enable();
        resumeButton.disable();
        exitButton.disable();

        sw.Start();
        sound.Play();
    }
}
