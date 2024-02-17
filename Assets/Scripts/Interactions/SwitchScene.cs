using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string SceneName;
    public void ToNextScene()//跳转到下一个界面
    {
        SceneManager.LoadScene(SceneName);
    }

    public void RestartScene()//重启这个界面
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
