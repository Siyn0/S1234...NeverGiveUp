using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game3PlayerController : MonoBehaviour
{
    public float MoveSpeed = 10f;//移动速度（最初是用transform.position移动，
                                 //现改为刚体，这个值是向刚体施加的力的大小）
    public int FireTime = 10;//发射子弹的间隔时间

    private int CurrentTime = 0;//距离上一次发射子弹过去多久

    private float HP = 100;//血量

    public Image HPBar;//血条
    public GameObject DiePanel;//死亡界面

    public GameObject Bullet;//子弹的预制体

    private Vector2 MoveVector, RightVector, LeftVector, UpVector, DownVector;//四个方向的向量

    private void Start()
    {
        MoveVector = new Vector2(0f,0f);
        RightVector = new Vector2(MoveSpeed, 0f);
        LeftVector = new Vector2(-MoveSpeed, 0f);
        UpVector = new Vector2(0f, MoveSpeed);
        DownVector = new Vector2(0f, -MoveSpeed);
    }
    private void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            MoveVector += RightVector;
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            MoveVector += LeftVector;
        }
        if(Input.GetAxis("Vertical") > 0)
        {
            MoveVector += UpVector;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            MoveVector += DownVector;
        }

        gameObject.GetComponent<Rigidbody2D>().AddForce(MoveVector);
        MoveVector = Vector2.zero;
    }

    private void FixedUpdate()
    {
        if(CurrentTime < FireTime)
        {
            CurrentTime ++;
        }
        else
        {
            GameObject.Instantiate(Bullet,transform.position + new Vector3(5f,0f,0f), transform.rotation);
            CurrentTime = 0;
        }
    }

    private void UpdateHP()
    {
        HPBar.fillAmount = HP / 100f;
        Debug.Log("HP:" + HP / 100f);
    }

    public void LoseHP()
    {
        Debug.Log("掉血");
        HP -= 10;
        UpdateHP();
        if (HP <= 0)
        {
            DiePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
