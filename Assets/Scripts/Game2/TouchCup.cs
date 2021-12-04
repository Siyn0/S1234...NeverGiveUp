using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCup : MonoBehaviour
{
    public GameObject Player;
    public GameObject Canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("S9Win");
            Destroy(Player.GetComponent<Game2PlayerController>());
            Destroy(Player.GetComponent<Rigidbody2D>());
            Canvas.transform.GetChild(0).gameObject.SetActive(false);
            Canvas.transform.GetChild(1).gameObject.SetActive(true);
            Invoke("PrintCenter", 3f);
        }
    }

    private void PrintCenter()
    {
        Canvas.transform.GetChild(2).gameObject.SetActive(true);
        Canvas.transform.GetChild(3).gameObject.SetActive(true);
    }
}
