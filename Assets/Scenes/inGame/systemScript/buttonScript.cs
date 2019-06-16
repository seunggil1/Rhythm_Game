using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    Vector2 incomingVec;

    private GameObject character;
    private Vector3 t;

    public Transform target_wall;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Instantiate(Resources.Load<GameObject>(commonData.character) as GameObject) as GameObject;
        character.SetActive(true);

        t = character.transform.localScale;
        t.x = -t.x;
        character.transform.localScale = t;
    }

    // Update is called once per frame
    private void Update()
    {
        t = transform.position;
        t.x -= 1.75f;
        t.y -= 1.0f;
        character.transform.position = t;
    }
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, 1.0f);
        //Debug.DrawRay(transform.position, transform.right * 1.5f, Color.red);

        if (hit)
        {
            target_wall = hit.transform;

            incomingVec = hit.point - new Vector2(transform.position.x, transform.position.y);
        }
        else
            target_wall = null;
    }
    public void onHit()
    {
        if(target_wall != null)
        {
            target_wall.gameObject.GetComponent<Collider2D>().enabled = false;
            if(incomingVec.x < 0.05)
                commonData.score += 10;
            else if(incomingVec.x < 0.2)
                commonData.score += 5;
            else
                commonData.score += 2;

            commonData.combo++;
            commonData.correctNote++;
            if (commonData.nowMaxCombo < commonData.combo)
                commonData.nowMaxCombo = commonData.combo;
        }
    }
}
