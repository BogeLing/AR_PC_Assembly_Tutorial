using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTap_Display : MonoBehaviour
{
    public GameObject[] buttonObjects; // ����һ���������飬�����洢button����
    public GameObject[] targets; // ����һ���������飬�����洢Ҫ���Ƶ�����

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ����û�������������
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // �����������һ�����ߣ�����������ڵ�λ��
            RaycastHit hitInfo;
            for (int i = 0; i < buttonObjects.Length; i++) // ����ÿ��button����
            {
                if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, LayerMask.GetMask(LayerMask.LayerToName(buttonObjects[i].layer)))) // ���������ײ���˵�i��button���壨ֻ���button���ڵ�ͼ�㣩
                {
                    targets[i].SetActive(true); // ��ʾ��i������
                }
            }
        }
    }
}
