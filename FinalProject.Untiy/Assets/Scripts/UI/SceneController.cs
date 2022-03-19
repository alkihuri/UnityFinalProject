using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    [SerializeField, Range(1, 10)] int _introSceneDuration = 10;
    [SerializeField] bool _isIntroScene;

    public void LoadGameSceneWithDelay(int seconds)
    {
        Invoke("LoadGameScene", seconds);
    }

    private void Start()
    {
        if(_isIntroScene)
            LoadGameSceneWithDelay(_introSceneDuration);
    }

    public void LoadGameScene()
    {
        LoadScene("Game");
    }
     public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
