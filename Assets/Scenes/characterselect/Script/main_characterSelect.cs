using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_characterSelect : MonoBehaviour
{
    public UiData acti1;
    public UiData acti2;
    public UiData acti3;
    public UiData acti4;

    public UiData lock2;
    public UiData lock3;
    public UiData lock4;

    public GameObject check;

    public ButtonData ch1;
    public ButtonData ch2;
    public ButtonData ch3;
    public ButtonData ch4;

    public Text score;
    private Vector3 t;
    public bool itchanged;
    // Start is called before the first frame update
    void Start()
    {
        new screenSetting().screenSet(1920);

        acti1 = new UiData("1000");
        acti2 = new UiData("1100");
        acti3 = new UiData("1110");
        acti4 = new UiData("1111");

        lock2 = new UiData("lock2");
        lock3 = new UiData("lock3");
        lock4 = new UiData("lock4");

        
        ch1 = new ButtonData("select1");
        ch2 = new ButtonData("select2");
        ch3 = new ButtonData("select3");
        ch4 = new ButtonData("select4");

        acti1.disable();
        acti2.disable();
        acti3.disable();
        acti4.disable();

        lock2.disable();
        lock3.disable();
        lock4.disable();

        

        ch1.disable();
        ch2.disable();
        ch3.disable();
        ch4.disable();
        if (commonData.Totalscore < 500)
        {
            acti1.enable();
            ch1.enable();

            lock2.enable();
            lock3.enable();
            lock4.enable();
        }
        else if(commonData.Totalscore > 500 && commonData.Totalscore < 1000)
        {
            acti2.enable();
            ch1.enable();
            ch2.enable();

            lock3.enable();
            lock4.enable();
        }
        else if(commonData.Totalscore >1000 && commonData.Totalscore < 2000)
        {
            acti3.enable();
            ch1.enable();
            ch2.enable();
            ch3.enable();

            lock4.enable();
        }
        else
        {
            acti4.enable();
            ch1.enable();
            ch2.enable();
            ch3.enable();
            ch4.enable();
        }

        score.text = "Total Score: " + commonData.Totalscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (itchanged)
        {
            switch (commonData.character)
            {
                case "character1":
                    t = check.transform.position;
                    t.x = ch1.buttonEnable.gameObject.transform.position.x;
                    check.transform.position = t;
                    break;
                case "character2":
                    t = check.transform.position;
                    t.x = ch2.buttonEnable.gameObject.transform.position.x;
                    check.transform.position = t;
                    break;
                case "character3":
                    t = check.transform.position;
                    t.x = ch3.buttonEnable.gameObject.transform.position.x;
                    check.transform.position = t;
                    break;
                case "character4":
                    t = check.transform.position;
                    t.x = ch4.buttonEnable.gameObject.transform.position.x;
                    check.transform.position = t;
                    break;
            }
            itchanged = !itchanged;
        }
    }
}
