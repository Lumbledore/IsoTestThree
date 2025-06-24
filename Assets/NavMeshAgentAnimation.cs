using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentAnimation : MonoBehaviour
{
    NavMeshAgent _agent;
    Animator _animator;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        _animator.SetFloat("Speed", _agent.velocity.magnitude);
    }
}
