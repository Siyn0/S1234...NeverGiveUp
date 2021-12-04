using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    
    void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(Quit);
    }

    private void Quit()
    {
        Application.Quit();
    }
}
