using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour
{
    public GameObject ob;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = Resources.Load<Sprite>(commonData.path + "/sprite/button/pause") as Sprite;
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnMouseUp()
    {
        ob.GetComponent<main_inGame>().pauseButton.isClicked = true;
    }
}
