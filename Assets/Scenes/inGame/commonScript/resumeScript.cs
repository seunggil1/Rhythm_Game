﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resumeScript : MonoBehaviour
{
    public GameObject ob;

    void Start()
    { 
    }

    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        ob.GetComponent<main_inGame>().resumeButton.isClicked = true;
    }
}
