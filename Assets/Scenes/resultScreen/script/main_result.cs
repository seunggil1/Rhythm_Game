using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class main_result : MonoBehaviour
{
    Stopwatch sw;

    public Text totalNote;
    public Text correct;
    public Text incorrect;
    public Text Accuracy;
    public Text combo;
    public Text score;
    public Text continueText;

    bool tn = true;
    bool cr = true;
    bool ir = true;
    bool acc = true;
    bool com = true;
    bool sco = true;
    bool ct = true;

    public GameObject button;

    int totalNotecount;
    // Start is called before the first frame update
    void Start()
    {
        new screenSetting().screenSet(1920);
        sw = new Stopwatch();
        sw.Start();

        if (commonData.maxCombo < commonData.nowMaxCombo)
            commonData.maxCombo = commonData.nowMaxCombo;
        commonData.Totalscore += commonData.score;
        userDataIO.saveData();

        totalNotecount = commonData.correctNote + commonData.incorrectNote;
    }

    // Update is called once per frame
    void Update()
    {
        if (tn && sw.ElapsedMilliseconds > 2000)
        {
            totalNote.text = totalNote.text + " " + totalNotecount.ToString();
            tn = !tn;
        }
        if (cr && sw.ElapsedMilliseconds > 3500)
        {
            correct.text = correct.text + "  " + commonData.correctNote.ToString();
            cr = !cr;
        }    
        if (ir && sw.ElapsedMilliseconds > 5000)
        {
            incorrect.text = incorrect.text + "  " + commonData.incorrectNote.ToString();
            ir = !ir;
        }
        if (acc && sw.ElapsedMilliseconds > 6500)
        {
            Accuracy.text = Accuracy.text + " " + (100 * (commonData.correctNote) / (float)(totalNotecount)).ToString().Substring(0,5) + "%";
            acc = !acc;
        }
        if (com && sw.ElapsedMilliseconds > 8000)
        {
            combo.text = combo.text + "  " + commonData.nowMaxCombo.ToString();
            com = !com;
        }
        if (sco && sw.ElapsedMilliseconds > 9500)
        {
            score.text = score.text + " " + commonData.score.ToString();
            sco = !sco;
        }
        if (ct && sw.ElapsedMilliseconds > 11000)
        {
            continueText.enabled = true;
            button.GetComponent<BoxCollider2D>().enabled = true; // 버튼 활성화
            ct = !ct;
            sw.Stop();
            commonData.clear();
        }
        
    }
}
