using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcAnimatorController : MonoBehaviour
{

    [SerializeField] NavMeshAgent _npc; 

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetFloat("Speed", _npc.velocity.magnitude);
    }
}
