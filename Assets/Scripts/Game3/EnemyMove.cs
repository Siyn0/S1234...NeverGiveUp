using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MoveSpeed = 0.1f;

    private void Update()
    {
        transform.position += new Vector3(-MoveSpeed, 0f, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("碰撞");
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<Game3PlayerController>().LoseHP();
            Destroy(gameObject);
        }
    }
}
