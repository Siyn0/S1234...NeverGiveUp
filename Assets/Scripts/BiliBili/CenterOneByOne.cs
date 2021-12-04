using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOneByOne : MonoBehaviour
{
    public int ChangeTime = 10;

    private int CurrentTime = 0;
    private int Index = 0;

    private void FixedUpdate()
    {
        if(CurrentTime == ChangeTime)
        {
            transform.GetChild(Index).gameObject.SetActive(true);
            CurrentTime = 0;
            Index += 1;
        }
        else
        {
            CurrentTime += 1;
        }

    }
}
