using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    void Start()
    {
        transform.GetComponent<Text>().color = new Color(Random.Range(0,100)*0.01f, Random.Range(0, 100)*0.01f, Random.Range(0, 100)*0.01f);
    }
}
