using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using TMPro;

[System.Serializable]
public class ExportToCSV : MonoBehaviour
{
    private List<string[]> rowData = new List<string[]>();
    [SerializeField]
    public ScoutingDataList scoutingDataList = new ScoutingDataList();
    public TMP_InputField fileLocationInputField;

    private string path;
    private TextAsset jsonFile;
    string[] rowDataTemp = new string[12];

    void Start()
    {
        CheckFolderExistence("/ImportData");
        CheckFolderExistence("/Spreadsheets");
        fileLocationInputField.text = Application.persistentDataPath;

        path = Application.persistentDataPath + "/ImportData/data.json";
        // Debug.Log("Data Path: " + Application.dataPath);
        // Debug.Log("Persistent Data Path: " + Application.persistentDataPath);
    }

    public void Save()
    {
        CheckFolderExistence("/Spreadsheets");
        if (!File.Exists(Application.persistentDataPath + "/Spreadsheets/" + "Saved_data.csv"))
        {
            // Creating First row of titles manually..
            rowDataTemp = new string[12];
            rowDataTemp[0] = "Name";
            rowDataTemp[1] = "Match Number";
            rowDataTemp[2] = "Team Number";
            rowDataTemp[3] = "Autonomous Inner Count";
            rowDataTemp[4] = "Autonomous Inner Inner Count";
            rowDataTemp[5] = "Autonomous Outer Count";
            rowDataTemp[6] = "TeleOp Inner Count";
            rowDataTemp[7] = "TeleOp Inner Inner Count";
            rowDataTemp[8] = "TeleOp Outer Count";
            rowDataTemp[9] = "Driving Effectiveness";
            rowDataTemp[10] = "Defense Effectiveness";
            rowDataTemp[11] = "Additional Notes";
            rowData.Add(rowDataTemp);
        }
        else
        {
            Debug.Log("File exists.. not adding titles");
        }

        jsonFile = new TextAsset(File.ReadAllText(path));
        Debug.Log(jsonFile);

        if (jsonFile != null)
        {
            scoutingDataList = JsonUtility.FromJson<ScoutingDataList>(jsonFile.text);

            int x = 0;
            // You can add up the values in as many cells as you want.
            foreach (ScoutingData scoutingData in scoutingDataList.ScoutingData)
            {
                rowDataTemp = new string[12];
                rowDataTemp[0] = scoutingDataList.ScoutingData[x].name.ToString();
                rowDataTemp[1] = scoutingData.matchNumber;
                rowDataTemp[2] = scoutingData.teamName;
                rowDataTemp[3] = scoutingData.autonomousInnerCount;
                rowDataTemp[4] = scoutingData.autonomousInnerInnerCount;
                rowDataTemp[5] = scoutingData.autonomousOuterCount;
                rowDataTemp[6] = scoutingData.teleOpInnerCount;
                rowDataTemp[7] = scoutingData.teleOpInnerInnerCount;
                rowDataTemp[8] = scoutingData.teleOpOuterCount;
                rowDataTemp[9] = scoutingData.drivingEffectiveness;
                rowDataTemp[10] = scoutingData.defenseEffectiveness;
                rowDataTemp[11] = scoutingData.additionalNotes;
                rowData.Add(rowDataTemp);
                Debug.Log("Test: " + scoutingDataList.ScoutingData[x].name.ToString());
                x++;
            }
        }
        else
        {
            Debug.Log("Asset is null");
        }


        StreamWriter outStream = System.IO.File.CreateText(getPath());

        string[][] output = new string[rowData.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = rowData[i];
        }

        int length = output.GetLength(0);
        string delimiter = ",";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));


        Debug.Log("Exporting to CSV!");

        outStream.WriteLine(sb);
        outStream.Close();
    }

    // Following method is used to retrive the relative path as device platform
    public string getPath()
    {
        // #if UNITY_EDITOR
        return Application.persistentDataPath + "/Spreadsheets/" + "Saved_data.csv";
        // #elif UNITY_ANDROID
        //         return Application.persistentDataPath+"Saved_data.csv";
        // #elif UNITY_IPHONE
        //         return Application.persistentDataPath+"/"+"Saved_data.csv";
        // #else
        //         return Application.dataPath + "/" + "Saved_data.csv";
        // #endif
    }

    void CheckFolderExistence(string folderLocation)
    {
        if (!Directory.Exists(Application.persistentDataPath + folderLocation))
        {
            Directory.CreateDirectory(Application.persistentDataPath + folderLocation);
        }
    }
}