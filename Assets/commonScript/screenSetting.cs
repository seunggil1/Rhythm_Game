using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenSetting : MonoBehaviour
{
    public void screenSet()
    {
    
        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        
        Screen.SetResolution(1280, 720, true);
    }
}
