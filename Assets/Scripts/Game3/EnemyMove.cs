using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MoveSpeed = 1f;

    private Vector2 MoveV;

    private void Start()
    {
        MoveV = new Vector2(-MoveSpeed, 0f); ;
    }

    private void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(MoveV);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("碰撞");
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<Game3PlayerController>().LoseHP();
            Destroy(gameObject);
        }
    }
}
