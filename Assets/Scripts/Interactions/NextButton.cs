using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    void Start()
    {
        Global.SessionIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void NextScene()
    {
        Global.FinishStep(((StepNames)(Global.SessionIndex-1)).ToString());
        SceneManager.LoadScene(Global.SessionIndex+1);
    }
}
