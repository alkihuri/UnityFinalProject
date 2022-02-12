using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    CharacterController _cc;
    [SerializeField, Range(1,10)] float _speed = 1 ;

    [SerializeField, Range(0, 45)] float _yAngleRestriction = 45;
    [SerializeField] GameObject _camera;
    [SerializeField] bool isMouseInvers = true;
    float delta = 0;
    private Quaternion startRotation;
    private float yCameraAngle ; 
    private float xCameraAngle;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
        _cc = GetComponent<CharacterController>();
        _camera = GetComponentInChildren<Camera>().gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        DoMovement(); 
        CursorModeSettings(); 
    }

    private void DoMovement()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 directionOfMovement = (transform.forward * v + transform.right * h) * _speed;
        _cc.SimpleMove(directionOfMovement);
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(0, mouseX, 0);
        mouseY = isMouseInvers ? -mouseY : mouseY;
        YAngleRestrictionFeature(mouseY);

    }

    private void YAngleRestrictionFeature(float mouseY)
    {
        yCameraAngle += mouseY;
        xCameraAngle = transform.rotation.eulerAngles.y;
        var clampedYCameraAngle = Mathf.Clamp(yCameraAngle, -_yAngleRestriction, _yAngleRestriction);
        if (yCameraAngle > _yAngleRestriction)
            yCameraAngle = _yAngleRestriction;
        if (yCameraAngle < -_yAngleRestriction)
            yCameraAngle = -_yAngleRestriction;
        _camera.transform.rotation = Quaternion.Euler(clampedYCameraAngle, xCameraAngle, 0);
    }

    private static void CursorModeSettings()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.None;
        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
    }
}
