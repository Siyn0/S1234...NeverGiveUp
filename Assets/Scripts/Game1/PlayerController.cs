using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// 移动速度
    /// </summary>
    public float MoveSpeed = 0.01f;

    /// <summary>
    /// 跳跃力度
    /// </summary>
    public float JumpForce = 800f;

    /// <summary>
    /// 地面判断物体的碰撞盒
    /// </summary>
    private BoxCollider2D isGroundCol;

    /*    /// <summary>
        /// 跳跃间隔
        /// </summary>
        public float JumpTime = 0.2f;

        private float isJumpTime = 0.2f;//记录距离上次跳跃过去的时间*/

    /*
        /// <summary>
        /// 攻击间隔
        /// </summary>
        public float AttackTime = 1f;

        private float isAttackTime = 1f;*/


    private void Start()
    {
        isGroundCol = transform.GetChild(1).GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.position += new Vector3(MoveSpeed, 0f, 0f);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            transform.position += new Vector3(-MoveSpeed, 0f, 0f);
        }

        if(Input.GetAxis("Jump") > 0)
        {
            if(isGroundCol.IsTouching())
            {
                transform.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
            }
            
        }

        /*
        //跳跃计时器
        if(isJumpTime < JumpTime)
        {
            isJumpTime += 0.01f;
        }
*//*
        if (Input.GetAxis("Fire1") > 0)
        {
            if (isAttackTime >= AttackTime)
            {
                //transform.GetChild(0).GetComponent<Animator>().SetBool("isAttack", true);
                transform.GetChild(0).GetComponent<Animator>().Play("Attack");
                isAttackTime = 0f;
            }
        }

        //攻击计时器
        if (isAttackTime < AttackTime)
        {
            isAttackTime += 0.01f;
        }
        else
        {
            //transform.GetChild(0).GetComponent<Animator>().SetBool("isAttack", false);
            transform.GetChild(0).GetComponent<Animator>().Play("Idel");
        }*/
    }
}
