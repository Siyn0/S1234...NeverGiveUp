using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLeft : MonoBehaviour
{
    public float Speed = 4f;

    private void FixedUpdate()
    {
        transform.position += new Vector3(-Speed, 0f, 0f);
    }
}
