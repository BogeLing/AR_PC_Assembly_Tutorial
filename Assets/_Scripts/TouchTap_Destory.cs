using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTap_Destory : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ����û�������������
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // �����������һ�����ߣ�����������ڵ�λ��
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) // ���������ײ��������
            {
                Destroy(hitInfo.collider.gameObject); // ������ײ����
            }
        }
    }
}
