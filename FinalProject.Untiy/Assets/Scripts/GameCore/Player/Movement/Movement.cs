using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    CharacterController _cc;
    [SerializeField, Range(1,10)] float _speed = 1 ;
    [SerializeField] GameObject _camera;
    // Start is called before the first frame update
    void Start()
    {
        _cc = GetComponent<CharacterController>();
        _camera = GetComponentInChildren<Camera>().gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal"); 
        Vector3 directionOfMovement = (transform.forward * v + transform.right * h) * _speed;
        _cc.SimpleMove(directionOfMovement);
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(0, mouseX * _speed, 0);
        _camera.transform.Rotate(-mouseY*_speed, 0, 0);
    }
}
