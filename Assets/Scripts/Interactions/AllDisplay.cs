using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDisplay : MonoBehaviour
{
    public GameObject[] TargetGroup; // 声明一个公共数组，用来存储要控制的物体

    public void DisplayAllComponents()
    {
        foreach (var item in TargetGroup)
        {
            item.gameObject.SetActive(true);
            /*for (int i = 0; i < item.transform.childCount; i++)
            {
                item.transform.GetChild(i).gameObject.SetActive(true);
            }*/
        }
    }
}
