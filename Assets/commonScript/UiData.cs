using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiData : MonoBehaviour
{
    public Image buttonImage;
    public SpriteRenderer buttonShow;
    

    public UiData(string Name)
    {
        GameObject ob;
        ob = GameObject.Find(Name);
        buttonImage = ob.GetComponent<Image>();
  
        buttonShow = ob.GetComponent<SpriteRenderer>();
    }
    
    public void enable()
    {
        buttonShow.enabled = true;
    }

    public void disable()
    {
        buttonShow.enabled = false;
    }
}
