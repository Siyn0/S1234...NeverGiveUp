using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    private int S = 0;
    private Text[] SText = {null,null,null,null,null,null,null,null,null,null,null,null };
    private int t = 0;

    public GameObject Sword;
    private void OnEnable()
    {
        for(int i = 0; i < 12; i++)
        {
            SText[i] = transform.GetChild(i).GetComponent<Text>();
            Debug.Log(i);
        }
        
    }

    private void FixedUpdate()
    {
        if(t >= 10)
        {
            Debug.Log("S:" + S);

            Sword.transform.GetChild((S + 12) % 12).gameObject.SetActive(false);
            Sword.transform.GetChild(((S + 13) % 12)).gameObject.SetActive(true);


            if (S >= 12)
            {
                SText[(S+12) % 12].text = "S" + (S+1);
            }

            S += 1;
            t = 0;
        }
        t += 1;
    }
}
