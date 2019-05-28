using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonData : MonoBehaviour
{
    public BoxCollider2D buttonEnable;
    public bool isClicked; 
    // Start is called before the first frame update
    public ButtonData(string Name)
    {
        GameObject ob;
        ob = GameObject.Find(Name);
        buttonEnable = ob.GetComponent<BoxCollider2D>();
    }

    public void enable()
    {
        isClicked = false;
        buttonEnable.enabled = true;
    }

    public void disable()
    {
        isClicked = false;
        buttonEnable.enabled = false;
    }

}
