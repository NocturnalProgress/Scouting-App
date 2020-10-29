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

        // GeneralSharingiOSBridge.ShareSimpleText(Resources.Load(jsonPath) as TextAsset);

        StartCoroutine(TakeScreenshotAndShare());
    }

    private IEnumerator TakeScreenshotAndShare()
    {
        yield return new WaitForEndOfFrame();

        // Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        // ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        // ss.Apply();

        // string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        // File.WriteAllBytes(filePath, ss.EncodeToPNG());

        // To avoid memory leaks
        // Destroy(ss);


        new NativeShare().AddFile(jsonPath)
            .SetSubject("Scouting Data").SetText("Hello world!")
            .SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
            .Share();

        // Share on WhatsApp only, if installed (Android only)
        //if( NativeShare.TargetExists( "com.whatsapp" ) )
        //	new NativeShare().AddFile( filePath ).AddTarget( "com.whatsapp" ).Share();
    }
}