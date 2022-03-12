using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{

    RaycastHit _objectOnHitLine;
    [SerializeField] GameObject _camera;
    [SerializeField] FloatingJoystick _turnJoystick;
    // Update is called once per frame
    void FixedUpdate()
    {
      //  if(_turnJoystick.Vertical != 0 )
      //        Shoot();
    }

    public  void Shoot()
    {
        Debug.DrawRay(transform.position, _camera.transform.localPosition, Color.yellow);

        if (Physics.Raycast(transform.position, _camera.transform.forward, out _objectOnHitLine))
        {
            GameObject _gameObjectOnHitLine = _objectOnHitLine.transform.gameObject;
            Debug.DrawLine(transform.position, _gameObjectOnHitLine.transform.position, Color.red);
            if ( _gameObjectOnHitLine.GetComponent<DestoyebleObject>())
            {
                AudioManager.Instance.PlayShoot();
                Destroy(_gameObjectOnHitLine);
            }
        }
    }
}
