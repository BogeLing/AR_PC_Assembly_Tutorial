using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject PauseMenu;
    public void OnPauseButton()
    {
        this.gameObject.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    } 
}