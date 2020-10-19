using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationSystem : MonoBehaviour
{
    public GameObject notificationPrefab;
    [HideInInspector] public int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayNotificationCanvas()
    {
        GameObject notification = Instantiate(notificationPrefab.gameObject, new Vector3(0, 0, 0), transform.rotation) as GameObject;
        notification.transform.SetParent(gameObject.transform, false);
        notification.transform.localScale = new Vector3(1, 1, 1);

        switch (index)
        {
            case 6:
                notification.GetComponent<Notification>().notificationMessage.text = "Error uploading form";
                break;
            case 5:
                notification.GetComponent<Notification>().notificationMessage.text = "Form upload complete!";
                break;
            case 4: // Not connected to internet
                notification.GetComponent<Notification>().notificationMessage.text = "Error: Not connected to internet";
                break;
            case 3: // Finished saving scouting data
                notification.GetComponent<Notification>().notificationMessage.text = "Finished saving scouting data!";
                break;
            case 2: // Finished exporting scouting data
                notification.GetComponent<Notification>().notificationMessage.text = "Finished exporting scouting data!";
                break;
            case 1: // Finished generating QR Code
                notification.GetComponent<Notification>().notificationMessage.text = "Finished creating QR Code!";
                break;
            default:
                // Debug.Log("Error!");
                break;
        }
        index = 0;
    }

    public void ErrorUploadingForm()
    {
        index = 6;
        DisplayNotificationCanvas();
    }
    public void FormUploadComplete()
    {
        index = 5;
        DisplayNotificationCanvas();
    }

    public void NotConnectedToInternet()
    {
        index = 4;
        DisplayNotificationCanvas();
    }

    public void FinishedSaving()
    {
        index = 3;
        DisplayNotificationCanvas();
    }

    public void FinishedExportingData()
    {
        index = 2;
        DisplayNotificationCanvas();
    }

    public void FinishedGeneratingQRCode()
    {
        index = 1;
        DisplayNotificationCanvas();
    }
}