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
        transform.LookAt(_player.transform.position);
        _agent.SetDestination(_player.transform.position);
    }
}
