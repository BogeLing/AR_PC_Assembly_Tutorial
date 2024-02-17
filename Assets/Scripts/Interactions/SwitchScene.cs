using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string SceneName;
    public void ToNextScene()//��ת����һ������
    {
        SceneManager.LoadScene(SceneName);
    }

    public void RestartScene()//�����������
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
