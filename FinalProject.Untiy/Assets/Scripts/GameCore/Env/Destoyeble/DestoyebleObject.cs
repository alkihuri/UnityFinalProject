using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyebleObject : MonoBehaviour
{
    [SerializeField] GameObject _particleSystem;
    private void OnDestroy()
    {
        var score = PlayerPrefs.GetFloat("Score");
        score++;
        PlayerPrefs.SetFloat("Score", score);
        GameObject ps = Instantiate(_particleSystem,transform.position,transform.rotation);
        Destroy(ps, 5);
    }
}
