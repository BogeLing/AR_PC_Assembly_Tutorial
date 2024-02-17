using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTap_Hide : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 如果用户按下了鼠标左键
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 从摄像机发射一条射线，穿过鼠标所在的位置
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) // 如果射线碰撞到了物体
            {
                if (hitInfo.collider.gameObject.tag != "Button") // 如果碰撞物体的tag不是"Button"
                {
                    if (hitInfo.collider.gameObject.transform.parent != null) // 如果碰撞物体有父物体
                    {
                        hitInfo.collider.gameObject.transform.parent.gameObject.SetActive(false); // 隐藏碰撞物体的父物体
                    }
                    else // 如果碰撞物体没有父物体
                    {
                        hitInfo.collider.gameObject.SetActive(false); // 隐藏碰撞物体本身
                    }
                }
            }
        }
    }
}
