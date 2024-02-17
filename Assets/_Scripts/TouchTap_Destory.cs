using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTap_Destory : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 如果用户按下了鼠标左键
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 从摄像机发射一条射线，穿过鼠标所在的位置
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) // 如果射线碰撞到了物体
            {
                Destroy(hitInfo.collider.gameObject); // 销毁碰撞物体
            }
        }
    }
}
