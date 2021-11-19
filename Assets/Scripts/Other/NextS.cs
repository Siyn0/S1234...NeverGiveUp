using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextS : MonoBehaviour
{
    public string NextSceneName;
    void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(ClickNext);
    }

    private void ClickNext()
    {
        SceneManager.LoadScene(NextSceneName);
    }
}
