using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DesktopTypeItem : MonoBehaviour
{
    public TextMeshProUGUI chooseText;
    public TextMeshProUGUI TypeName;
    public GameObject PlaceHolder;
    private void Awake()
    {
        /*chooseText = GameObject.Find("Canvas/Panel/SessionType/TextArea/Text").GetComponent<TextMeshProUGUI>();*/
        /*TypeName = this.transform.Find("Text").GetComponent<TextMeshProUGUI>().text;*/
    }

    public void OnButtonClick()
    {
        PlaceHolder.SetActive(false);
        chooseText.text = TypeName.text;
    }
}
