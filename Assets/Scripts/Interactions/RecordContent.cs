using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RecordContent : MonoBehaviour
{
    public RecordItem SampleItem;
    public GameObject EmptyWarning;

    void Awake()
    {
        if (Global.Sessions!=null && Global.Sessions.Any<SessionModel>())
        {
            foreach (SessionModel session in Global.Sessions)
            {
                RecordItem item = Instantiate(SampleItem, Vector3.zero, Quaternion.identity, this.transform);
                item.SessionInfo = session;
            }
        }
        else
        {
            EmptyWarning.SetActive(true);
        }
    }
}
