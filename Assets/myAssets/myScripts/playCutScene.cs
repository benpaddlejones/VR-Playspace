using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playCutScene : MonoBehaviour
{
    public GameObject videoPlayer;
    public GameObject videoTrigger;
    public int timeToStop;
    private bool playCount = false;

    void Start()
    {
        videoPlayer.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (!playCount)
        {
            if (player.gameObject.tag == "MainCamera")
            {
                playCount = true;
                videoPlayer.SetActive(true);
                Destroy(videoPlayer, timeToStop);
                Destroy(videoTrigger, timeToStop);
            }
        }
    }
}
