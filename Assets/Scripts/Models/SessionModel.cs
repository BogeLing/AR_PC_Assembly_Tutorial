using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[Serializable]
public class SessionModel
{
    public string SessionId;
    public string SessionTitle;
    public string SavedTime;
    public List<StepModel> Steps;

    public SessionModel()
    {
        SessionId = Guid.NewGuid().ToString();
        SessionTitle = string.Empty;
        SavedTime = System.DateTime.Now.ToString();
        Steps = new List<StepModel>()
        {
            new StepModel(StepNames.SSD),
            new StepModel(StepNames.ATX),
            new StepModel(StepNames.CPU),
            new StepModel(StepNames.CPUHeatSink),
            new StepModel(StepNames.GPU),
            new StepModel(StepNames.Jumper),
            new StepModel(StepNames.Memory),
            new StepModel(StepNames.MotherBoard),
        };
    }
    public SessionModel(Guid id, string sessionTitle)
    {
        SessionId = id.ToString();
        SessionTitle = sessionTitle;
        Steps = new List<StepModel>();
        SavedTime = System.DateTime.Now.ToString();
        Steps = new List<StepModel>()
        {
            new StepModel(StepNames.SSD),
            new StepModel(StepNames.ATX),
            new StepModel(StepNames.CPU),
            new StepModel(StepNames.CPUHeatSink),
            new StepModel(StepNames.GPU),
            new StepModel(StepNames.Jumper),
            new StepModel(StepNames.Memory),
            new StepModel(StepNames.MotherBoard),
        };
        SessionTitle = sessionTitle;
    }
}

[Serializable]
public class StepModel //����ģ�ͣ�����װ��SSD��GPU��һ��session��8��step��
{
    public int StepId;
    public string StepName;
    public int Finished; //0��ʾû����ɣ�1��ʾ���

    public StepModel()
    {
    }

    public StepModel(StepNames name)
    {
        StepId = (int)name;
        StepName = name.ToString();
    }
}

