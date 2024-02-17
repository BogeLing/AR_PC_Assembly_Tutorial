using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordItem : MonoBehaviour
{
    public SessionModel SessionInfo;
    private StepButtons steps;
    public void Awake()
    {
        steps = GameObject.Find("Canvas/Panel/StepButtons").GetComponent<StepButtons>();
    }
    void Start()
    {
        transform.Find("Button/Text").GetComponent<TextMeshProUGUI>().text = SessionInfo.SessionTitle;
    }

    public void OnButton()
    {
        Global.CurrentSesion = SessionInfo;//同步被选择的场景
        steps.ShowProgress();
    }

    public void OnDeleteButton()
    {
        Global.Sessions.RemoveAll(item => item.SessionId == SessionInfo.SessionId);
        Global.SaveSessions();
        Destroy(gameObject);
        if (Global.Sessions.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
