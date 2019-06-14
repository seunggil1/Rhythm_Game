using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class generator_moster : MonoBehaviour
{
    private string path;
    private string music;
    public int line;

    noteStream data;
    List<float> timeIndex;

    private float nowTime;

    public GameObject monsterObject;
    public Transform missileLocation;

    public int missileMaxPool;
    private memorypoolingMonster mPool;
    private GameObject[] missileArray;

    private int i = 0;

    private void OnApplicationQuit()
    {
       mPool.Dispose();
    }


    private void Start()
    {
        path = commonData.path;
        music = commonData.musicName;
        timeIndex = new List<float>();
        data = new noteStream(path+"/music", music + "_" + line);
        data.inputData(ref timeIndex);

        mPool = new memorypoolingMonster();
        mPool.Create(monsterObject, missileMaxPool);
        missileArray = new GameObject[missileMaxPool];

        nowTime = 0.0f;
    }
    void FixedUpdate()
    {
        nowTime += Time.deltaTime;
        while (i < timeIndex.Count && timeIndex[i] - 2 < nowTime)
        {
            MakeMonster();
            i++;
        }
        if (mPool.getUsingMemory() != 0)
            checkMonster();
    }

    private void MakeMonster()
    {
        for (int i = 0; i < missileMaxPool; i++)
        {
          
            if (missileArray[i] == null)
            {
                missileArray[i] = mPool.NewItem();
                missileArray[i].transform.position = missileLocation.transform.position;
                break;
            }
        }
    }
    private void checkMonster() // 화면 밖에 나간 몬스터 삭제
    {
        for (int i = 0; i < missileMaxPool; i++)
        {
            if (missileArray[i])
            {
                if (missileArray[i].GetComponent<Collider2D>().enabled == false)
                {
                    missileArray[i].GetComponent<Collider2D>().enabled = true;
                    mPool.RemoveItem(missileArray[i]);
                    missileArray[i] = null;
                }
            }
        }
    }
}
