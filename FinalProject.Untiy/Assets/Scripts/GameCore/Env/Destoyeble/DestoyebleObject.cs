using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyebleObject : MonoBehaviour
{
    [SerializeField] GameObject _ps;
    private void OnDestroy()
    {
        GameObject ps = Instantiate(_ps);
        Destroy(ps, 5);
    }
}
