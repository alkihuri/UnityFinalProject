using System;
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
        _maxNumOfNpc = 15;
        CheckNpcList();
    }

    public void CheckNpcList()
    {
        


        foreach (GameObject npc in _npcList)
        {
            if (npc == null)
                _npcList.Remove(npc);
        }

        if (!(_npcList.Count < _maxNumOfNpc))
            return;

        if (_npcList.Count < _maxNumOfNpc)
        {
            SpawnNpc();
        }
    }
    private void Update()
    {
        CheckNpcList();
    }
    private void SpawnNpc()
    {
        Vector3 randomPostion = _spawnList[UnityEngine.Random.Range(0, _spawnList.Count - 1)].transform.position;
        GameObject newNpc = Instantiate(_npc,randomPostion,Quaternion.identity); 
        _npcList.Add(newNpc);
    }
}
