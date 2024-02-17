using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Quit Game.");
        Application.Quit();
    }
}
