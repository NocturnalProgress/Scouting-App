using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Data : MonoBehaviour
{
    //Allows data to be accesed by GenerateQRCode.cs or SerializeData.cs

    public AutonomousCounters autonomousCounters;
    public TeleOpCounters teleOpCounters;
    public TMP_InputField nameInputField;
    public TMP_InputField teamNameInputField;
    public TMP_InputField matchNumberInputField;
    public TMP_InputField additionalNotesInputField;
    public TMP_Dropdown drivingEffectivenessDropDown;
    public TMP_Dropdown defenseEffectivenessDropDown;
    [HideInInspector] public string data;
    public NotificationSystem notificationSystem;


    [SerializeField]
    public List<DataToExport> scoutingDataContainer = new List<DataToExport>();

    public void AddToJsonList()
    {
        DataToExport dataToExport = new DataToExport();
        dataToExport.name = nameInputField.text;
        dataToExport.teamName = teamNameInputField.text;
        dataToExport.matchNumber = matchNumberInputField.text;

        dataToExport.autonomousInnerCount = autonomousCounters.innerCount.ToString();
        dataToExport.autonomousInnerInnerCount = autonomousCounters.innerInnerCount.ToString();
        dataToExport.autonomousOuterCount = autonomousCounters.outerCount.ToString();

        dataToExport.teleOpInnerCount = teleOpCounters.innerCount.ToString();
        dataToExport.teleOpInnerInnerCount = teleOpCounters.innerInnerCount.ToString();
        dataToExport.teleOpOuterCount = teleOpCounters.outerCount.ToString();

        dataToExport.drivingEffectiveness = drivingEffectivenessDropDown.value.ToString();
        dataToExport.defenseEffectiveness = defenseEffectivenessDropDown.value.ToString();
        dataToExport.additionalNotes = additionalNotesInputField.text;

        scoutingDataContainer.Add(dataToExport);

        int tempNum = Convert.ToInt32(matchNumberInputField.text) + 1;
        matchNumberInputField.text = tempNum.ToString();

        PrepareForNextMatch();
        notificationSystem.FinishedSaving();

    }

    public string SerializeToJson()
    {
        Container container = new Container(scoutingDataContainer);
        string json = JsonUtility.ToJson(container, true);
        Debug.Log(json);
        return json;
    }

    public void PrepareForNextMatch()
    {
        // Initial Data
        // nameInputField.text = "";
        teamNameInputField.text = "";

        // Autonomous
        autonomousCounters.innerCount = 0;
        autonomousCounters.innerInnerCount = 0;
        autonomousCounters.outerCount = 0;

        autonomousCounters.innerCounter.text = "0";
        autonomousCounters.innerInnerCounter.text = "0";
        autonomousCounters.outerCounter.text = "0";

        // TeleOp
        teleOpCounters.innerCount = 0;
        teleOpCounters.innerInnerCount = 0;
        teleOpCounters.outerCount = 0;

        teleOpCounters.innerCounter.text = "0";
        teleOpCounters.innerInnerCounter.text = "0";
        teleOpCounters.outerCounter.text = "0";

        // End Game
        drivingEffectivenessDropDown.value = 0;
        defenseEffectivenessDropDown.value = 0;
        additionalNotesInputField.text = "";
    }
}

[System.Serializable]
public class DataToExport
{
    public string name;
    public string matchNumber;
    public string teamName;
    public string autonomousInnerCount;
    public string autonomousInnerInnerCount;
    public string autonomousOuterCount;
    public string teleOpInnerCount;
    public string teleOpInnerInnerCount;
    public string teleOpOuterCount;
    public string drivingEffectiveness;
    public string defenseEffectiveness;
    public string additionalNotes;
}

// Wrapper to allow list to be serialized
[System.Serializable]
public class Container
{
    [SerializeField]
    public List<DataToExport> ScoutingData;

    public Container(List<DataToExport> _dataList)
    {
        ScoutingData = _dataList;
    }
}
