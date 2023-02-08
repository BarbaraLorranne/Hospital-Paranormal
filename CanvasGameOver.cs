using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasGameOver : MonoBehaviour
{
    private GameObject CanvasGO;
    void Start()
    {
        CanvasGO = GameObject.Find("CanvasGO");
    }

    // Update is called once per frame
    void Update()
    {
        GoToLvl1();
    }
    public void GoToLvl1()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Fase1");
        }
    }
}
