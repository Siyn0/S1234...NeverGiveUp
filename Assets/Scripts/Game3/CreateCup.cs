using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCup : MonoBehaviour
{
    //生成奖杯的区域高度34
    public GameObject Cup;

    public float CreateTime = 10f;
    private float CurrentTime = 0f;

    private void FixedUpdate()
    {
        if (CurrentTime >= CreateTime)
        {
            GameObject.Instantiate(Cup,new Vector3(34f, Random.Range(17,-17),0f), transform.rotation,transform);
            CurrentTime = 0f;
        }
        CurrentTime += 0.1f;
    }
}
