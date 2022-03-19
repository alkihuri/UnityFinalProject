using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsUI : MonoBehaviour
{
    [SerializeField] string _key;
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetFloat(_key).ToString("#.");
    }
}
