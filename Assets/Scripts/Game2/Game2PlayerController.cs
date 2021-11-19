using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2PlayerController : MonoBehaviour
{
    public float Speed = 0.05f;
    public float Jump = 800f;
    public float JumpTime = 0.1f;
    private float JumpCurrent = 0f;

    private void Update()
    {
        transform.position += new Vector3(Speed, 0f, 0f);
        if(JumpCurrent >= JumpTime)
        {
            if (Input.GetAxis("Fire1") > 0)
            {
                transform.GetComponent<Rigidbody2D>().AddForce(Vector2.up * Jump);
                JumpCurrent = 0f;
            }
        }
        JumpCurrent += 0.01f;
    }
}
