using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenSetting : MonoBehaviour
{
    public void screenSet(int num = 1280)
    {
    
        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        
        if(num == 1920)
            Screen.SetResolution(1920, 1080, true);
        else
            Screen.SetResolution(1280, 720, true);
    }
}
