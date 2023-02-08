using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class SoulWomanSound : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent SoulWoman; //indica o objeto que irá se movimentar pela area azul da cena.
    private Transform point; //lugar para onde o inimigo vai.

    private AudioSource audioS;
    private bool isAudio;

    public GameObject JumpScarePanel;
    void Start()
    {
        SoulWoman = GetComponent<UnityEngine.AI.NavMeshAgent>();
        point = GameObject.Find("FPSController").transform;
        isAudio = false;
        audioS = GetComponent<AudioSource>();
        JumpScarePanel.SetActive(false);
        StopCoroutine(GoToGO());
    }

    // Update is called once per frame
    void Update()
    {
        SoulWoman.SetDestination(point.position);

        if(isAudio == true)
        {
            audioS.Play();
        }
        else
        {
            audioS.Stop();
        }
    }
    public void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Player"){
            Debug.Log("IsCollider");
            isAudio = true;
            JumpScarePanel.SetActive(true);
            Time.timeScale = 0;
            StartCoroutine(GoToGO());
        }
        else
        {
            JumpScarePanel.SetActive(false);
            isAudio = false;
            Time.timeScale = 1;
            StopCoroutine(GoToGO());
        }
    }
    IEnumerator GoToGO()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("GameOver");
    }
}
