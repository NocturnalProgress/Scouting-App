using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SerializeData : MonoBehaviour
{
    //Exports data to Json

    private string jsonPath;
    public GameObject data;
    public NotificationSystem notificationSystem;

    void Start()
    {
#if UNITY_EDITOR
        jsonPath = Application.persistentDataPath + "/ScoutingData/data.json";
#elif UNITY_STANDALONE_WIN
        jsonPath = Application.persistentDataPath + "/ScoutingData/data.json";
#elif UNITY_IOS
        jsonPath = Application.persistentDataPath + "/data.json";
#elif UNITY_STANDALONE_OSX
        jsonPath = Application.persistentDataPath + "/data.json";
#endif


    }

    public void SaveToJson()
    {
        string json = data.GetComponent<Data>().SerializeToJson();
        System.IO.File.WriteAllText(jsonPath, json);
        notificationSystem.FinishedExportingData();
    }
}