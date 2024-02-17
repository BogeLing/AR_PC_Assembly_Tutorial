using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeList
{
    public static string ListToJson<T>(List<T> list)
    {
        return JsonUtility.ToJson(new SerializationList<T>(list));
    }

    public static List<T> ListFromJson<T>(string str)
    {
        return JsonUtility.FromJson<SerializationList<T>>(str).ToList();
    }
}


[Serializable]
public class SerializationList<T>
{
    [SerializeField]
    List<T> target;
    public List<T> ToList() { return target; }

    public SerializationList(List<T> target)
    {
        this.target = target;
    }
}

