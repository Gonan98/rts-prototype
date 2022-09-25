using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class UnitBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject selection;

    private NavMeshAgent navMeshAgent;
    private float speed;
    public Transform objetivo;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.enabled = false;
        navMeshAgent.destination = objetivo.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
