using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnglesRestriction : MonoBehaviour
{
    [SerializeField] GameObject _camera;

    [SerializeField, Range(0, 45)] float _xRestriction;
    [SerializeField, Range(0, 45)] float _currentXCameraAngle;
    [SerializeField] bool _isOk;

    public bool IsOk { get { return _isOk; } }

    // Update is called once per frame
    void Update()
    { 
        _currentXCameraAngle = Mathf.Abs(_camera.transform.localEulerAngles.x);
        _isOk = _currentXCameraAngle < _xRestriction;
    }
}
