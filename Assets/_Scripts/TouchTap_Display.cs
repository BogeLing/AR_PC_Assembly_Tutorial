using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTap_Display : MonoBehaviour
{
    public GameObject[] buttonObjects; // 声明一个公共数组，用来存储button物体
    public GameObject[] targets; // 声明一个公共数组，用来存储要控制的物体

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 如果用户按下了鼠标左键
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 从摄像机发射一条射线，穿过鼠标所在的位置
            RaycastHit hitInfo;
            for (int i = 0; i < buttonObjects.Length; i++) // 遍历每个button物体
            {
                if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, LayerMask.GetMask(LayerMask.LayerToName(buttonObjects[i].layer)))) // 如果射线碰撞到了第i个button物体（只检测button所在的图层）
                {
                    targets[i].SetActive(true); // 显示第i个物体
                }
            }
        }
    }
}
