using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 몬스터 object 삭제
 * 
 * 화면에서 몬스터 삭제
 * player의 공격으로 인한 몬스터 제거
 * 
 * 
 * GetComponent<Collider2D>().enabled = false;만 하면 자동으로 삭제 됨.
 * 
 */
public class monster : MonoBehaviour
{
    public float MoveSpeed;
    public float DestroyXPos;
    public float DestroyYPos;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        // 만약에 몬스터의 위치가 DestroyXPos보다 작거나 DestroyYPos를 넘어서면
        if (transform.position.x <= DestroyXPos || transform.position.y >= DestroyYPos)
        {
            GetComponent<Collider2D>().enabled = false;
            commonData.combo = 0;
        }
    }
    
}
