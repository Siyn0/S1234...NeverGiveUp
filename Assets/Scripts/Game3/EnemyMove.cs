using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MoveSpeed = 1f;

    public GameObject[] DestroyParticle;

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
            GameObject.Instantiate(DestroyParticle[0], transform.position,transform.rotation);
            GameObject.Instantiate(DestroyParticle[1], transform.position, transform.rotation);
            GameObject.Instantiate(DestroyParticle[2], transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if(other.tag == "Wall" || other.tag == "Bullet")
        {
            GameObject.Instantiate(DestroyParticle[0], transform.position, transform.rotation);
            GameObject.Instantiate(DestroyParticle[1], transform.position, transform.rotation);
            GameObject.Instantiate(DestroyParticle[2], transform.position, transform.rotation);
            //由于奖杯碎片只有三个，并且不打算扩展，所以这里写死成三个
            Destroy(gameObject);
        }
    }
}
