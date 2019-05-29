using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour
{
    public GameObject ob;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnMouseUp()
    {
        ob.GetComponent<main_inGame>().exitButton.isClicked = true;
    }
}
