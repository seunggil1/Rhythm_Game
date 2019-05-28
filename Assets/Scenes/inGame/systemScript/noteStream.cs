using System;
using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class noteStream
{
    private FileStream fs;
    private StreamReader sr;
    private StringReader stringr;
    public noteStream(String path, String fileName)
    {//Resources\stage\1\music, musicName_line
        if (Application.platform == RuntimePlatform.Android)
        {
            TextAsset asset = Resources.Load(path + '/' + fileName) as TextAsset;
            string str = asset.text;
            stringr = new StringReader(str);
        }
        else
        {
            fs = new FileStream(Application.dataPath +"/Resources/"+ path+'/'+fileName+ ".txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
        }
    }

    public void inputData(ref List<float> data)
    {
        string time;
        if (Application.platform == RuntimePlatform.Android)
        {
            
            while ((time = stringr.ReadLine()) != null)
                data.Add(float.Parse(time));
        }
        else
        { 
            while ((time = sr.ReadLine()) != null)
                data.Add(float.Parse(time));
        }
    }
    ~noteStream()
    {
        if (Application.platform == RuntimePlatform.Android)
            stringr.Close();
        else
            sr.Close();
            
        fs.Close();
    }
}
