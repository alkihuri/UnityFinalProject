using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    [SerializeField] VideoPlayer _videoPlayer; 
    // Start is called before the first frame update
    void Start()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)_videoPlayer.frame > (int)_videoPlayer.frameCount / 2)
            _videoPlayer.Pause();
    }
}
