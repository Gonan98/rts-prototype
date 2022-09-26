using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unit : MonoBehaviour
{
    private Animator _animator;
    private NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        UnitSelections.Instance.Units.Add(this.gameObject);
        _animator = GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("running", transform.position != _agent.destination);
    }

    private void OnDestroy()
    {
        UnitSelections.Instance.Units.Remove(this.gameObject);
    }
}
