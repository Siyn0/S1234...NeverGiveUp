using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Horizontal;//横向弹幕
    public GameObject Center;//中间的弹幕

    public GameObject NextButton;//下一关按钮
    public GameObject Tip;//按键提示

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Horizontal.SetActive(true);
            Tip.SetActive(false);
            Invoke("CenterActive", 3f);
        }
    }

    private void CenterActive()
    {
        Center.SetActive(true);
        NextButton.SetActive(true);

    }
}
