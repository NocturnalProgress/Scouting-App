using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
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

        jsonPath = Application.persistentDataPath + "/ScoutingData" + randomNumber + ".json";

        string json = data.GetComponent<Data>().SerializeToJson();
        System.IO.File.WriteAllText(jsonPath, json);
        notificationSystem.FinishedExportingData();
    }
}