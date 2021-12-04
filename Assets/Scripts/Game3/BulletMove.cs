using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float MoveSpeed = 1f;

    private Vector2 MoveV;

    private void Start()
    {
        MoveV = new Vector2(MoveSpeed, 0f); ;
    }

    private void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(MoveV);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boss" || collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
