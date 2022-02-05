using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnglesRestriction : MonoBehaviour
{
    [SerializeField] GameObject _camera;

    [SerializeField, Range(0, 45)] float _xRestriction;
    [SerializeField, Range(-45, 45)] float _currentXCameraAngle;
    [SerializeField, Range(-45, 45)] float _currentClampedXCameraAngle;
    [SerializeField] bool _isOk;

    public bool IsOk { get { return _isOk; } }

    // Update is called once per frame
    void Update()
    {
        _currentXCameraAngle = _camera.transform.localEulerAngles.x ;
        _currentClampedXCameraAngle = Mathf.Clamp(_currentXCameraAngle, -_xRestriction, _xRestriction);
        _isOk = _currentXCameraAngle < _xRestriction;
        
    }
}
