using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game3PlayerController : MonoBehaviour
{
    public float MoveSpeed = 0.1f;
    private int HP = 100;
    public Image HPBar;
    public GameObject DiePanel;

    private void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.position += new Vector3(MoveSpeed, 0f, 0f);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            transform.position += new Vector3(-MoveSpeed, 0f, 0f);
        }
        if(Input.GetAxis("Vertical") > 0)
        {
            transform.position += new Vector3(0f, MoveSpeed, 0f);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += new Vector3(0f, -MoveSpeed, 0f);
        }
    }

    private void UpdateHP()
    {
        HPBar.fillAmount = HP / 100;
    }

    public void LoseHP()
    {
        HP -= 10;
        UpdateHP();
        if (HP <= 0)
        {
            DiePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
