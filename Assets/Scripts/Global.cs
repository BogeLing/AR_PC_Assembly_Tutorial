using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
public class Global
{
    public static SessionModel CurrentSesion;
    public static List<SessionModel> Sessions;
    public static int SessionIndex;
    public static string DataPath = Application.dataPath + "/Sources/SessionsRecord.txt";

    public static void OpenProgram()
    {
        /*if (!File.Exists(DataPath))
        {
            File.CreateText(DataPath);
        }
        */
        ReadSession();
    }
     
    public static void CreateSession(string title)
    {
        CurrentSesion = new SessionModel(Guid.NewGuid(),title);
    }

    public static void ModifySession()
    {
        if(Sessions!=null && CurrentSesion!=null)
        {
            Sessions.RemoveAll(item => item.SessionId == CurrentSesion.SessionId);
            CurrentSesion.SavedTime = DateTime.Now.ToString();
            Sessions.Add(CurrentSesion);
            SaveSessions();
        }
    }

    public static void SaveSessions()
    {
        string jsonString = SerializeList.ListToJson<SessionModel>(Sessions);
        Debug.Log(jsonString);
        PlayerPrefs.SetString("sessions", jsonString);
        //File.WriteAllText(DataPath, JsonString);
    }

    public static void ReadSession()
    {
        //string JsonString = File.ReadAllText(DataPath);
        if (!PlayerPrefs.HasKey("sessions"))
        {
            PlayerPrefs.SetString("sessions", "");
        }
        string jsonString = PlayerPrefs.GetString("sessions");
        if (jsonString != null && jsonString != "")
        {
            Sessions = SerializeList.ListFromJson<SessionModel>(jsonString);
            if(Sessions.Count == 0)
            {
                Global.CurrentSesion = null;
            }
        }
        else
        {
            Sessions = new List<SessionModel> { };
        }
    }


    //当一个Step完成后（如SSD，CPU），需要调用该方法，在存档中标记该Step已完成。
    //传入的参数stpName必须来自Enum.cs中的StepNames，指的是用户当前完成的Step的名字。
    public static void FinishStep(string stepName)
    {
        foreach(var step in CurrentSesion.Steps)
        {
            if (step.StepName == stepName)
            {
                step.Finished = 1;
                ModifySession();
            }
        }
    }
}
