using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseButton;
    
    public void OnResumeMenu()
    {
        this.gameObject.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void OnPauseMenu()
    {
        this.gameObject.SetActive(true);
    }
}
