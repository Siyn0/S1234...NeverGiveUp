using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Horizontal;//横向弹幕
    public GameObject Center;//中间的弹幕

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Horizontal.SetActive(true);
            Invoke("CenterActive", 3f);
        }
    }

    private void CenterActive()
    {
        Center.SetActive(true);
    }
}
