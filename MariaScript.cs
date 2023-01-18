using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MariaScript : MonoBehaviour
{
    private NavMeshAgent inimigo; //indica o objeto que irá se movimentar pelaarea azul da cena.
    private Transform point; //lugar para onde o inimigo vai.

    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
        point = GameObject.Find("PontoParada").transform;
    }

    // Update is called once per frame
    void Update()
    {
        inimigo.SetDestination(point.position);
    }
}
