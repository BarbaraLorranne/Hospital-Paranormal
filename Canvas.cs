using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 
public class Canvas : MonoBehaviour
{
    public GameObject btnJogar; 
    void Start()
    {
        btnJogar.SetActive(true); 

    }

    void Update()
    {
        
    }
    public void ComeçarJogo() 
    {
        SceneManager.LoadScene("Fase1"); 
    }
}
