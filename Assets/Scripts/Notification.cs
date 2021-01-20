using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
    This script is added to the "Notification" prefab when a notification is created.
    Its job is to remove the notification from the user's screen after a certain amount of time.
    It's basically a timer.
*/

public class Notification : MonoBehaviour
{
    public TMP_Text notificationMessage;
    public Slider slider;
    public float maxTime = 5f;
    private float timeLeft;

    private void Start()
    {
        timeLeft = maxTime;
    }

    private void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            slider.value = timeLeft / maxTime;
        }
        else
        {
            //Close notification
            Destroy(gameObject);
        }
    }
}