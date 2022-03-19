using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    [SerializeField] GameObject _npc;
    [SerializeField] List<GameObject> _npcList = new List<GameObject>();
    [SerializeField] List<GameObject> _spawnList;
    [SerializeField, Range(1, 100)] float _maxNumOfNpc;
    // Start is called before the first frame update
    void Start()
    {
        _maxNumOfNpc = 0;
    }

    public void CheckNpcList()
    {
        if
    }
}
