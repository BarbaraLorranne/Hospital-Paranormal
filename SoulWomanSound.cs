using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(AudioSource))]

public class SoulWomanSound : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent SoulWoman; //indica o objeto que irá se movimentar pelaarea azul da cena.
    private Transform point; //lugar para onde o inimigo vai.

    private AudioSource audioS;
    private bool isAudio;

    void Start()
    {
        SoulWoman = GetComponent<UnityEngine.AI.NavMeshAgent>();
        point = GameObject.Find("FPSController").transform;
        isAudio = false;
        audioS = GetComponent<AudioSource>();
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
        }   
    }
}
