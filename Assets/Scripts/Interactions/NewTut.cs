using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewTut : MonoBehaviour
{
    public TMP_InputField SessionTitle;
    private string sceneName = "RecordsScene";
    public void CreateNewSession()
    {
        string title = SessionTitle.text;
        Global.CreateSession(title);
        Global.ModifySession();
        SceneManager.LoadScene(sceneName);
    }
}
