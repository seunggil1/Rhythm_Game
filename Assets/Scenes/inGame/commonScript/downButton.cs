﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downButton : MonoBehaviour
{
    public GameObject ob;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (ob.transform.position.y != -3)
            ob.transform.Translate(Vector2.down * 3.0f);
    }
}