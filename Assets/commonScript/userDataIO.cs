using UnityEngine;
using System.IO;
static public class userDataIO
{
    static public void saveData()
    {
        FileStream fs = new FileStream(Application.persistentDataPath + "PlayerInfo.txt",
            FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(commonData.character);
        sw.WriteLine(commonData.Totalscore);
        sw.WriteLine(commonData.maxCombo);

        sw.Close();
        fs.Close();

    }
    static public void readData()
    {
        FileStream fs = new FileStream(Application.persistentDataPath + "PlayerInfo.txt",
            FileMode.Open, FileAccess.Read);
        if (fs != null)
        {
            StreamReader sr = new StreamReader(fs);
            commonData.character = sr.ReadLine();
            commonData.Totalscore = int.Parse(sr.ReadLine());
            commonData.maxCombo = int.Parse(sr.ReadLine());

            sr.Close();
            fs.Close();
        }
    }
}
