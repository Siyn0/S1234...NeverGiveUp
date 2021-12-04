using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    private void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(ClickNext);
    }

    private void ClickNext()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game3");
    }
}
