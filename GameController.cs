using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject introtxt;
    public int paperCollected;
    private GameObject PaperScript;
    public GameObject franciscoTxt1;
    public GameObject tiredPanel;

    public bool franciscoTxt1bool;
    public bool tiredpBool;

    public Transform teleportTarget;
    public GameObject thePlayer;
    void Start()
    {
        introtxt.gameObject.SetActive(true);
        paperCollected = 0;
        franciscoTxt1.SetActive(false);
        tiredPanel.SetActive(false);
        StopCoroutine(Tiredp());
        StopCoroutine(FrancisTxt1Destroy());
    }

    void Update()
    {
        CloseIntro();
        CollectedPaper();
        MissionPanel();
    }

    public void CatchPaper()
    {
        paperCollected++;
    }
    public void CollectedPaper()
    {
        if (paperCollected == 1)
        {
            //por som do capeta;
            franciscoTxt1.SetActive(true);
            franciscoTxt1bool = true;
            StartCoroutine(FrancisTxt1Destroy());
            paperCollected++;
        }
    }
    public void MissionPanel()
    {
        if (franciscoTxt1 == false && franciscoTxt1bool == true)
        {
            StopCoroutine(FrancisTxt1Destroy());
            tiredPanel.SetActive(true);
            StartCoroutine(Tiredp());

        }
        if(tiredPanel == false && tiredpBool == true)
        {
            StopCoroutine(Tiredp());
        }

    }
    IEnumerator FrancisTxt1Destroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(franciscoTxt1);

    }
    IEnumerator Tiredp()
    {
        yield return new WaitForSeconds(3f);
        Destroy(tiredPanel);
        franciscoTxt1bool = false;
    }
    public void CloseIntro()
    {
        if (Input.GetMouseButtonDown(0))
        {
            introtxt.gameObject.SetActive(false);
        }
    }
}
