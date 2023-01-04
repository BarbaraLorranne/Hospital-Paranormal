using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Paper : MonoBehaviour
{
    public GameObject objPaper;
    public GameObject paperCube;

    [SerializeField]
    public bool paper;
    void Start()
    {
        objPaper.gameObject.SetActive(false);
        paper = false;
    }
    public void OnTriggerStay(Collider coll)
    {
        if (coll.tag == "Player" && Input.GetMouseButtonDown(0))
        {
            Debug.Log("Has collision!");
            paper = true;
            objPaper.SetActive(true);

        }
    }
    public void ClosePaper()
    {
        Debug.Log("CHECK CLOSE PAPER");
        if (Input.GetMouseButtonDown(0) && paper ==true)
        {
            Debug.Log("PRESS LEFT BUTTON MOUSE");
            Destroy(paperCube);
            objPaper.gameObject.SetActive(false);
        }

    }
}
