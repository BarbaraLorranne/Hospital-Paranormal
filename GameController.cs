using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject introtxt;
    public GameObject gameOVerPanel;
    public int paperCollected;
    private GameObject PaperScript;
    public GameObject franciscoTxt1;
    public GameObject endDayOne;
    public GameObject tiredPanel;
    public int mission;
    void Start()
    {
        introtxt.gameObject.SetActive(true);
        gameOVerPanel.gameObject.SetActive(false);
        paperCollected = 0;
        franciscoTxt1.SetActive(false);
        endDayOne.SetActive(false);
        tiredPanel.SetActive(false);
        mission = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CloseIntro();
        CloseWarningSleep();
        ClosePanelEndDayOne();
        CollectedPaper();
        missionPanel();
    }
    public void CloseIntro()
    {
        if (Input.GetMouseButtonDown(0))
        {
            introtxt.gameObject.SetActive(false);
        }
    }
    public void CloseWarningSleep()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tiredPanel.gameObject.SetActive(false);
        }
    }
    public void ClosePanelEndDayOne()
    {
        if (Input.GetMouseButtonDown(0))
        {
            endDayOne.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        gameOVerPanel.gameObject.SetActive(true);
    }
    public void CatchPaper()
    {
        paperCollected++;
    }
    public void CollectedPaper()
    {
        if (paperCollected == 3)
        {
            //por som do capeta;
            franciscoTxt1.SetActive(true);
            StartCoroutine(FrancisTxt1Destroy());
            paperCollected++;
        }
    }
    public void missionPanel()
    {
        if (franciscoTxt1 == false)
        {
            tiredPanel.SetActive(true);
        }
        if(tiredPanel == false)
        {
            endDayOne.SetActive(true);
            //faz um teleporte do Francisco para o próprio quarto.
        }
    }
    IEnumerator FrancisTxt1Destroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(franciscoTxt1);

    }
}
