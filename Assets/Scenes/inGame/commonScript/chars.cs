using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chars : MonoBehaviour
{
    public GameObject ob;
    Vector3 t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t = ob.transform.position;
        t.x -= 1.75f;
        t.y -= 1.0f;
        transform.position = t;
    }
}
