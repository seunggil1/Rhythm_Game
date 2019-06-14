using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_mainMenu : MonoBehaviour
{
    public UiData menu;
        public ButtonData gameStart;
        public ButtonData login;
        public ButtonData exit;

    public UiData select;
        public ButtonData music1;
        public ButtonData music2;
        public ButtonData music3;

    public UiData musicinfo;
        public ButtonData left;
        public ButtonData right;
        public ButtonData selectThis;

    public UiData back;
        public ButtonData backbutton;

    private int preStage = 0;
    private int stage = 1;

    void Start()
    {
        new screenSetting().screenSet();

        menu = new UiData("menu");
        gameStart = new ButtonData("gameStart");
        //login = new ButtonData("login");
        exit = new ButtonData("exit");

        select = new UiData("selectMusic");
        music1 = new ButtonData("music1");
        music2 = new ButtonData("music2");
        music3 = new ButtonData("music3");

        musicinfo = new UiData("musicInfo");
        left = new ButtonData("left");
        selectThis = new ButtonData("select");
        right = new ButtonData("right");

        back = new UiData("back");
        backbutton = new ButtonData("backbutton");

        enableMenu();
        disableSelectmusic();
        disableMusicinfo();
        disableBack();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Escape) || backbutton.isClicked == true)
        {
            
            if(menu.buttonShow.enabled == true)
                UnityEngine.SceneManagement.SceneManager.LoadScene("startScreen");
            else if(select.buttonShow.enabled == true)
            {
                enableMenu();
                disableSelectmusic();
                disableBack();
            }
            else
            {
                enableSelectmusic();
                disableMusicinfo();
                enableBack();
            }
        }
        if(gameStart.isClicked == true)
        {
            disableMenu();
            enableSelectmusic();
            enableBack();
        }
        else if (music1.isClicked == true)
        {
            Debug.Log("1 clicked");
            stage = 1;
            disableSelectmusic();
            enableMusicinfo();
        }
        else if (music2.isClicked == true)
        {
            Debug.Log("2 clicked");
            stage = 2;
            disableSelectmusic();
            enableMusicinfo();
        }
        else if (music3.isClicked == true)
        {
            stage = 3;
            disableSelectmusic();
            enableMusicinfo();
        }
        else if (left.isClicked == true)
        {
            if (stage != 1)
                stage--;
            left.enable();
        }
        else if (right.isClicked == true)
        {
            if (stage != 3)
                stage++;
            right.enable();
        }
        else if (selectThis.isClicked == true)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("inGame");
        }

        if(stage == 1 && stage != preStage)
        {
            preStage = stage;
            commonData.path = "stage/1";
            musicinfo.buttonShow.sprite = Resources.Load<Sprite>("1");
        }
        else if(stage == 2 && stage != preStage)
        {
            preStage = stage;
            commonData.path = "stage/2";
            musicinfo.buttonShow.sprite = Resources.Load<Sprite>("2");
        }
        else if (stage == 3 && stage != preStage)
        {
            preStage = stage;
            commonData.path = "stage/3";
            musicinfo.buttonShow.sprite = Resources.Load<Sprite>("3");
        }


    }
    /*private void OnDrag(Vector2 delta)
    {
        if(musicinfo.buttonShow == true)
        {
            if (delta.x < 0 && stage > 1)
                stage--;
            else if (delta.x > 0 && stage < 2)
                stage++;
        }
    }*/

    private void enableMenu()
    {
        menu.enable();
        gameStart.enable();
        //login.enable();
        exit.enable();
    }
    private void disableMenu()
    {
        menu.disable();
        gameStart.disable();
        //login.disable();
        exit.disable();
    }
    private void enableSelectmusic()
    {
        select.enable();
        music1.enable();
        music2.enable();
        music3.enable();
    }
    private void disableSelectmusic()
    {
        select.disable();
        music1.disable();
        music2.disable();
        music3.disable();
    }
    private void enableMusicinfo()
    {
        musicinfo.enable();
        left.enable();
        selectThis.enable();
        right.enable();
    }
    private void disableMusicinfo()
    {
        musicinfo.disable();
        left.disable();
        selectThis.disable();
        right.disable();
    }
    private void enableBack()
    {
        back.enable();
        backbutton.enable();
    }
    private void disableBack()
    {
        back.disable();
        backbutton.disable();
    }
}