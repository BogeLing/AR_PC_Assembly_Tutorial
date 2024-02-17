using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class StepButtons : MonoBehaviour
{
    public TextMeshProUGUI CurrentSessionTitle;
    //public GameObject Lock;
    public Color green = Color.white;
    Color black = Color.black;

    public void Start()
    {
        if(Global.CurrentSesion != null)
        {
            //Lock.SetActive(false);
            ShowProgress();
        }
        else
        {
            //Lock.SetActive(true);
        }
    }
    public void ShowProgress()
    {
        CurrentSessionTitle.text = Global.CurrentSesion.SessionTitle;
        foreach (var step in Global.CurrentSesion.Steps)
        {
            Transform tran = this.transform.Find(step.StepName + "Button");
            tran.GetComponent<Button>().interactable = true;
            if (step.Finished != 0)
            {
                tran.GetComponent<Image>().color = green;
            }
            else
            {
                tran.GetComponent<Image>().color = black;
            }
        }
    }
}
