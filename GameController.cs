using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject introtxt;
    public GameObject fimDeJogoPainel;
    public int papelColetado;
    void Start()
    {
        introtxt.gameObject.SetActive(true);
        fimDeJogoPainel.gameObject.SetActive(false);
        papelColetado = 0;
    }

    // Update is called once per frame
    void Update()
    {
        fechaIntro();
    }
    public void fechaIntro() {
        if (Input.GetMouseButtonDown(0))
        {
            introtxt.gameObject.SetActive(false);
        }
    }
    public void FimDeJogo()
    {
        fimDeJogoPainel.gameObject.SetActive(true);
    }
    public void PegarPapel()
    {
        papelColetado ++;
    }
}
