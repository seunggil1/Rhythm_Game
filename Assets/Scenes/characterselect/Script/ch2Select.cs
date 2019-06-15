using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2Select : MonoBehaviour
{
    public main_characterSelect ob;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseUp()
    {
        commonData.character = "character2";
        ob.itchanged = true;
        Debug.Log("2");
    }
}
