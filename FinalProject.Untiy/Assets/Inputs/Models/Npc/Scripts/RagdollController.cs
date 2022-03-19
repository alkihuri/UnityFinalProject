using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RagdollController : MonoBehaviour
{

    [SerializeField] List<Joint> _jointsList;
    [SerializeField] bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        _jointsList = GetComponentsInChildren<Joint>().ToList();
        SetStateToRagdoll(state); 
    }

    private void SetStateToRagdoll(bool stateToSet)
    {
        foreach (Joint joint in _jointsList)
        {
            joint.gameObject.SetActive(stateToSet);
        }
        GetComponentInChildren<NpcAnimatorController>().enabled = !stateToSet;
    }
     
}
