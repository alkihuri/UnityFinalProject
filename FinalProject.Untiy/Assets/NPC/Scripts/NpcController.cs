using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcController : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _player = GameObject.FindObjectOfType<Movement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, _player.transform.position)> 0.3f)
            transform.LookAt(_player.transform.position);
        if(_agent.isOnNavMesh)
            _agent.SetDestination(_player.transform.position);
    }
}
