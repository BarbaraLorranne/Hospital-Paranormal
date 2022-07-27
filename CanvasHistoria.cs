using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasHistoria : MonoBehaviour
{
    public GameObject txthistoria;
    public GameObject txthistoria2;
    public GameObject btnfase;
    private float tempo;
    void Start()
    {
        txthistoria.gameObject.SetActive(true);
        txthistoria2.gameObject.SetActive(false);
        btnfase.gameObject.SetActive(false);
    }
   
    void Update()
    {
        tempo = Time.time+1;

        if(tempo >= 10)
        {
            txthistoria2.gameObject.SetActive(true);
            txthistoria.gameObject.SetActive(false);
            btnfase.gameObject.SetActive(true);
        }       
        
    }
    public void IrPraFase()
    {
        SceneManager.LoadScene("Fase1");
    }
}
