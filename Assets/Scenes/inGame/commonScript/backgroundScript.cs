﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{
    SpriteRenderer ob;
    // Start is called before the first frame update
    void Start()
    {
        ob = GetComponent<SpriteRenderer>();
        ob.sprite = Resources.Load<Sprite>(commonData.path + "/sprite/background/[1920_1080]background") as Sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
