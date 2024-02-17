using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTap_Hide : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ����û�������������
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // �����������һ�����ߣ�����������ڵ�λ��
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) // ���������ײ��������
            {
                if (hitInfo.collider.gameObject.tag != "Button") // �����ײ�����tag����"Button"
                {
                    if (hitInfo.collider.gameObject.transform.parent != null) // �����ײ�����и�����
                    {
                        hitInfo.collider.gameObject.transform.parent.gameObject.SetActive(false); // ������ײ����ĸ�����
                    }
                    else // �����ײ����û�и�����
                    {
                        hitInfo.collider.gameObject.SetActive(false); // ������ײ���屾��
                    }
                }
            }
        }
    }
}
