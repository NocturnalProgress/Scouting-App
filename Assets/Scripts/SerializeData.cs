using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class SerializeData : MonoBehaviour
{
    //Exports data to Json

    private string jsonPath;
    public GameObject data;
    public NotificationSystem notificationSystem;

    void Start()
    {
        // string timeDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

    }

    public void SaveToJson()
    {
        int randomNumber = UnityEngine.Random.Range(00000, 99999);

#if UNITY_EDITOR
        jsonPath = Application.persistentDataPath + "/ScoutingData" + randomNumber + ".json";
#elif UNITY_STANDALONE_WIN
        jsonPath = Application.persistentDataPath + "/ScoutingData" + randomNumber + ".json";
#elif UNITY_IOS
        jsonPath = Application.persistentDataPath + "/ScoutingData" + randomNumber + ".json";
#elif UNITY_STANDALONE_OSX
        jsonPath = Application.persistentDataPath + "/ScoutingData" + randomNumber + ".json";
#endif

        string json = data.GetComponent<Data>().SerializeToJson();
        System.IO.File.WriteAllText(jsonPath, json);
        notificationSystem.FinishedExportingData();
    }
}