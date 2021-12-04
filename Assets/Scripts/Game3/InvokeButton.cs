using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeButton : MonoBehaviour
{
    public GameObject QuitButton;
    public GameObject Bili1;
    public GameObject Bili2;

    private void OnEnable()
    {
        Bili1.SetActive(true);
        Invoke("EnableQuit", 3f);
    }

    private void EnableQuit()
    {
        Bili2.SetActive(true);
        QuitButton.SetActive(true);
    }
}
