using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game3PlayerController : MonoBehaviour
{
    public float MoveSpeed = 10f;
    
    private float HP = 100;

    public Image HPBar;
    public GameObject DiePanel;

    private Vector2 MoveVector, RightVector, LeftVector, UpVector, DownVector;

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
