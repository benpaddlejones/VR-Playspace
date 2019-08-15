using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playKioskVideo : MonoBehaviour
{
    public GameObject videoPlayer2;
    public GameObject BlueBox;
    public GameObject GreenBox;
    public GameObject RedBox;
    public int timeToStop;
    private bool Red = false;
    private bool Green = false;

    void Start()
    {
        videoPlayer2.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "BlueObject")
        {
             Red = false;
             Green = false;
            RedBox.transform.position = new Vector3(14.0f, 0.0f, 22.8f);
            BlueBox.transform.position = new Vector3(12.0f, 0.0f, 22.8f);
            GreenBox.transform.position = new Vector3(13.0f, 0.0f, 22.8f);
        }
        if (player.gameObject.tag == "RedObject")
        {
            Red = true;
        }
        if (player.gameObject.tag == "GreenObject")
        {
             Green = true;
        }
        if (Red && Green)
        {
            videoPlayer2.SetActive(true);
            Destroy(videoPlayer2, timeToStop);
        }
    }
}
