using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_mainMenu : MonoBehaviour
{
    private float startTime;
    private float nowTime;

    public int Layer;
    public int stage;

    GameObject StageList;
    GameObject Stage1;
    GameObject Stage2;

    // Start is called before the first frame update
    void Start()
    {
        new screenSetting().screenSet();

        startTime = 0.0f;
        nowTime = 0.0f;

        StageList = GameObject.Find("[1280_720]stageList");
        Stage1 = GameObject.Find("[1280_720]stage1");
        Stage2 = GameObject.Find("[1280_720]stage2");
        
        Layer = 1;
        stage = 0;

        StageList.GetComponent<SpriteRenderer>().enabled = false;
        Stage1.GetComponent<SpriteRenderer>().enabled = false;
        Stage2.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;

        if (Layer >= 2)
            StageList.GetComponent<SpriteRenderer>().enabled = true;
        else
            StageList.GetComponent<SpriteRenderer>().enabled = false;

        if (Layer < 3)
            Stage1.GetComponent<SpriteRenderer>().enabled = false;
        if (Layer == 4)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("InGame");
        }

        if(Layer >= 3 && stage == 0)
        {
            Stage1.GetComponent<SpriteRenderer>().enabled = true;
            Stage2.GetComponent<SpriteRenderer>().enabled = false;
        }
        if(Layer >= 3 && stage == 1)
        {
            Stage1.GetComponent<SpriteRenderer>().enabled = false;
            Stage2.GetComponent<SpriteRenderer>().enabled = true;
        }
            

        if (Input.touchCount > 0)
            if(Layer < 4 && nowTime - startTime >= 0.5f)
            {
                Layer++;
                startTime = nowTime;
                if (Layer == 4)
                    stage = 1;
            }
                

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if (Layer > 1)
                    Layer--;
                else
                    UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
            }
        }
    }

    private void OnDrag(Vector2 delta)
    {
        if (Layer == 3 && delta.x < 0 && stage > 0)
        {
            stage--;
        }
        if (Layer == 3 && delta.x > 0 && stage < 1)
        {
            stage++;
        }
    }
}



