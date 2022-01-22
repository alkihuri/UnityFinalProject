using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    [SerializeField] GameObject _camera1; 
    [SerializeField] GameObject _camera2;
    void Update()
    { 
        _camera1.SetActive(Input.GetKey(KeyCode.G)); 
        _camera2.SetActive(!Input.GetKey(KeyCode.G)); 
    }
}
