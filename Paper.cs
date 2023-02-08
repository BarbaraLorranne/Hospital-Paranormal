using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Paper : MonoBehaviour
{
    public GameObject panelPaper;
    public GameObject paperCube;
    public GameObject gc;

    [SerializeField]
    public bool paper;
    void Start()
    {
        panelPaper.gameObject.SetActive(false);
        paperCube.gameObject.SetActive(true);
        paper = false;
        gc.GetComponent<GameController>();
    }
    public void OnTriggerStay(Collider coll)
    {
        if (coll.tag == "Player" && Input.GetMouseButtonDown(0) && paper ==false)
        {
            paper = true;
            panelPaper.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void ClosePaper()
    {
            Destroy(paperCube);
            Destroy(panelPaper);
            Time.timeScale = 1;
            gc.gameObject.GetComponent<GameController>().CatchPaper();
        

    }
}
