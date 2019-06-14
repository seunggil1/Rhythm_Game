using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upButton : MonoBehaviour
{
    public GameObject ob;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = Resources.Load<Sprite>(commonData.path + "/sprite/button/arrow_up") as Sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        if(ob.transform.position.y != 3)
            ob.transform.Translate(Vector2.up * 3.0f);
        else
            ob.transform.position = new Vector3(ob.transform.position.x, -3, ob.transform.position.z);
    }
}
