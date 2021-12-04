using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHP : MonoBehaviour
{
    private float HP = 100;//血量

    public Image HPBar;//血条
    public GameObject VictoryPanel;//胜利界面
    public GameObject CupCreater;//停止生成小奖杯


    private Vector3 RandomV3;//下一次移动的方向
    private int CurrentTime = 0;//距离上次移动过去的时间

    public int MoveTime = 30;//移动间隔

    private void OnEnable()
    {
        RandomV3 = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
    }
    private void Update()
    {
        if(CurrentTime < MoveTime)
        {
            CurrentTime++;
        }
        else
        {
            RandomV3 = new Vector3(Random.Range(-0.1f,0.1f), Random.Range(-0.1f,0.1f), 0f);
            CurrentTime = 0;
        }
        transform.position += RandomV3;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            HP -= 5;
            HPBar.GetComponent<Image>().fillAmount = HP / 100f;
            if(HP <= 0)
            {
                VictoryPanel.SetActive(true);
                Destroy(CupCreater);
                Destroy(this);
            }
        }
        else if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Game3PlayerController>().LoseHP();
        }
        
    }    
}
