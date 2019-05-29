using System.Collections;
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
    private void OnMouseUp()
    {
        if (ob.transform.position.y != -3)
            ob.transform.Translate(Vector2.down * 3.0f);
        else
            ob.transform.position = new Vector3(ob.transform.position.x, 3, ob.transform.position.z);
    }
}
