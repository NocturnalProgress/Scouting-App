﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SendData : MonoBehaviour
{
    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfsLIBRdjNIsryTAnQFi8R8Ksufdpmwvjqi0BmXE4JtTCLNlw/formResponse";

    public NotificationSystem notificationSystem;

    public Data data;


    public bool ConnectedToInternet()
    {
        UnityWebRequest request = new UnityWebRequest("https://www.google.com/forms/about/");
        if (request.error != null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    IEnumerator Post(string name, string teamName, string matchNumber, string autonomousUpperCount, string autonomousInnerCount, string autonomousLowerCount, string teleOpUpperCount, string teleOpInnerCount, string teleOpLowerCount, string drivingEffectiveness, string defenseEffectiveness, string climbingEffectiveness, string additionalNotes)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1015024617", name);
        form.AddField("entry.1415283686", teamName);
        form.AddField("entry.481944419", matchNumber);
        form.AddField("entry.1193038724", autonomousUpperCount);
        form.AddField("entry.1974190789", autonomousInnerCount);
        form.AddField("entry.1665466814", autonomousLowerCount);
        form.AddField("entry.287566910", teleOpUpperCount);
        form.AddField("entry.1381439776", teleOpInnerCount);
        form.AddField("entry.1310421016", teleOpLowerCount);
        form.AddField("entry.664449370", drivingEffectiveness);
        form.AddField("entry.607000157", defenseEffectiveness);
        form.AddField("entry.1350595043", climbingEffectiveness);
        form.AddField("entry.105519805", additionalNotes);

        UnityWebRequest www = UnityWebRequest.Post(BASE_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            notificationSystem.ErrorUploadingForm();
        }
        else
        {
            notificationSystem.FormUploadComplete();
        }
    }

    public void SendDataToForms()
    {
        if (ConnectedToInternet() == true)
        {
            StartCoroutine(Post(data.dataToExport.name, data.dataToExport.teamName, data.dataToExport.matchNumber, data.dataToExport.autonomousUpperCount, data.dataToExport.autonomousInnerCount, data.dataToExport.autonomousLowerCount, data.dataToExport.teleOpUpperCount, data.dataToExport.teleOpInnerCount, data.dataToExport.teleOpLowerCount, data.dataToExport.drivingEffectiveness, data.dataToExport.defenseEffectiveness, data.dataToExport.climbingEffectiveness, data.dataToExport.additionalNotes));
        }
        else
        {
            notificationSystem.NotConnectedToInternet();
        }
    }
}