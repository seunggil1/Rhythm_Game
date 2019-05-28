using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour
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
        ob.GetComponent<main_inGame>().pauseButton.isClicked = true;
    }
}
