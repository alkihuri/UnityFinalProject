using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{

    RaycastHit _objectOnHitLine;
    [SerializeField] GameObject _camera;
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, _camera.transform.localPosition, Color.yellow);

        if (Physics.Raycast(transform.position, _camera.transform.forward,out _objectOnHitLine))
        {
            GameObject _gameObjectOnHitLine = _objectOnHitLine.transform.gameObject;
            Debug.DrawLine(transform.position, _gameObjectOnHitLine.transform.position, Color.red); 
            if(Input.GetMouseButtonDown(0) && _gameObjectOnHitLine.GetComponent<DestoyebleObject>())
            {  
                Destroy(_gameObjectOnHitLine);
            }
        }
    }
}
