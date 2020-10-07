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
        jsonPath = Application.persistentDataPath + "/data.json";
    }

    public void SaveToJson()
    {
        string json = data.GetComponent<Data>().SerializeToJson();
        System.IO.File.WriteAllText(jsonPath, json);
        notificationSystem.FinishedExportingData();
    }
}