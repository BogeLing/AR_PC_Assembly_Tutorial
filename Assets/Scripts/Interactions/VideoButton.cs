using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VideoButton : MonoBehaviour
{
    public GameObject Video;
    private bool Key;
    private VuforiaBehaviour VuforiaCamera;
    private void Start()
    {
        Key = false;
        VuforiaCamera = GameObject.Find("ARCamera").GetComponent<VuforiaBehaviour>();
    }

    public void SwitchVideoStatus()
    {
        if (Key)
        {
            Key = false;
            VuforiaCamera.enabled = true;
            Video.SetActive(false);
        }
        else
        {
            Key = true;
            Video.SetActive(true);
            VuforiaCamera.enabled = false;
        }
    }
}
