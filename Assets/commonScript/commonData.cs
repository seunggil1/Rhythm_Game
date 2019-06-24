using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class commonData
{
    static public string path = "stage/2";
    static public string musicName = "music";

    static public string character = "character1"; //save
    static public int Totalscore = 625; //save
    static public int maxCombo = 0; // save

    static public int score = 400;
    static public int combo = 0;
    static public int nowMaxCombo = 0;
    static public int correctNote = 0;
    static public int incorrectNote = 0;

    static public void clear()
    {
        score = 0;
        combo = 0;
        nowMaxCombo = 0;
        correctNote = 0;
        incorrectNote = 0;
    }
}
