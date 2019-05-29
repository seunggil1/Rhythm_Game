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

    void Start()
    {
        new screenSetting().screenSet();

        menu = new UiData("menu");

        gameStart = new ButtonData("gameStart");
        login = new ButtonData("login");
        exit = new ButtonData("exit");

        select = new UiData("selectMusic");

        music1 = new ButtonData("music1");
        music2 = new ButtonData("music2");
        music3 = new ButtonData("music3");

        menu.enable();
        gameStart.enable();
        login.enable();
        exit.enable();

        select.disable();
        music1.disable();
        music2.disable();
        music3.disable();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDrag(Vector2 delta)
    {

    }
}



