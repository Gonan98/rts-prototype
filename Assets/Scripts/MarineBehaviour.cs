using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MarineBehaviour : MonoBehaviour
{
    public float Speed = 10.0f;
    private GameObject selection;
    public Transform objetivo;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private bool isMovingToASelectedPosition = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.speed = Speed;
        navMeshAgent.destination = objetivo.position;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("running", transform.position != navMeshAgent.destination);
    }

    public void Select()
    {
        selection.SetActive(true);
    }

    public void DeSelect()
    {
        selection.SetActive(false);
    }

    public void MoveTo(Vector3 position)
    {
        //if (IsDead()) return;

        //if (!_team.AI)
        //{
        //    _moveSound.Play();
        //}

        isMovingToASelectedPosition = true;
        navMeshAgent.speed = Speed;
        //RemoveTarget();
        SetDestination(position);
    }
    private void SetDestination(Vector3 position)
    {
        navMeshAgent.isStopped = false;
        navMeshAgent.SetDestination(position);
    }

}
