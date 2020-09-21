using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGroupScript : MonoBehaviour
{
    public Canvas mainCanvas;
    public Canvas initialDataCanvas;
    public Canvas autonomousCanvas;
    public Canvas teleOpCanvas;
    public Canvas endGameCanvas;
    public Canvas submitDataCanvas;

    private CanvasGroup mainCanvasGroup;
    private CanvasGroup initalDataCanvasGroup;
    private CanvasGroup autonomousCanvasGroup;
    private CanvasGroup teleOpCanvasGroup;
    private CanvasGroup endGameCanvasGroup;
    private CanvasGroup submitDataCanvasGroup;

    void Awake()
    {
        mainCanvasGroup = mainCanvas.GetComponent<CanvasGroup>();
        initalDataCanvasGroup = initialDataCanvas.GetComponent<CanvasGroup>();
        autonomousCanvasGroup = autonomousCanvas.GetComponent<CanvasGroup>();
        teleOpCanvasGroup = teleOpCanvas.GetComponent<CanvasGroup>();
        endGameCanvasGroup = endGameCanvas.GetComponent<CanvasGroup>();
        submitDataCanvasGroup = submitDataCanvas.GetComponent<CanvasGroup>();
    }

    void Start()
    {
        mainCanvasGroup.alpha = 1;
        mainCanvasGroup.interactable = true;
        mainCanvasGroup.blocksRaycasts = true;

        initalDataCanvasGroup.alpha = 0;
        initalDataCanvasGroup.interactable = false;
        initalDataCanvasGroup.blocksRaycasts = false;

        autonomousCanvasGroup.alpha = 0;
        autonomousCanvasGroup.interactable = false;
        autonomousCanvasGroup.blocksRaycasts = false;

        teleOpCanvasGroup.alpha = 0;
        teleOpCanvasGroup.interactable = false;
        teleOpCanvasGroup.blocksRaycasts = false;

        endGameCanvasGroup.alpha = 0;
        endGameCanvasGroup.interactable = false;
        endGameCanvasGroup.blocksRaycasts = false;

        submitDataCanvasGroup.alpha = 0;
        submitDataCanvasGroup.interactable = false;
        submitDataCanvasGroup.blocksRaycasts = false;
    }

    public void MainButton()
    {
        mainCanvasGroup.alpha = 1;
        mainCanvasGroup.interactable = true;
        mainCanvasGroup.blocksRaycasts = true;

        initalDataCanvasGroup.alpha = 0;
        initalDataCanvasGroup.interactable = false;
        initalDataCanvasGroup.blocksRaycasts = false;

        autonomousCanvasGroup.alpha = 0;
        autonomousCanvasGroup.interactable = false;
        autonomousCanvasGroup.blocksRaycasts = false;

        teleOpCanvasGroup.alpha = 0;
        teleOpCanvasGroup.interactable = false;
        teleOpCanvasGroup.blocksRaycasts = false;

        endGameCanvasGroup.alpha = 0;
        endGameCanvasGroup.interactable = false;
        endGameCanvasGroup.blocksRaycasts = false;

        submitDataCanvasGroup.alpha = 0;
        submitDataCanvasGroup.interactable = false;
        submitDataCanvasGroup.blocksRaycasts = false;
    }

    public void InitalDataButton()
    {
        mainCanvasGroup.alpha = 0;
        mainCanvasGroup.interactable = false;
        mainCanvasGroup.blocksRaycasts = false;

        initalDataCanvasGroup.alpha = 1;
        initalDataCanvasGroup.interactable = true;
        initalDataCanvasGroup.blocksRaycasts = true;

        autonomousCanvasGroup.alpha = 0;
        autonomousCanvasGroup.interactable = false;
        autonomousCanvasGroup.blocksRaycasts = false;

        teleOpCanvasGroup.alpha = 0;
        teleOpCanvasGroup.interactable = false;
        teleOpCanvasGroup.blocksRaycasts = false;

        endGameCanvasGroup.alpha = 0;
        endGameCanvasGroup.interactable = false;
        endGameCanvasGroup.blocksRaycasts = false;

        submitDataCanvasGroup.alpha = 0;
        submitDataCanvasGroup.interactable = false;
        submitDataCanvasGroup.blocksRaycasts = false;
    }

    public void AutonomousButton()
    {
        mainCanvasGroup.alpha = 0;
        mainCanvasGroup.interactable = false;
        mainCanvasGroup.blocksRaycasts = false;

        initalDataCanvasGroup.alpha = 0;
        initalDataCanvasGroup.interactable = false;
        initalDataCanvasGroup.blocksRaycasts = false;

        autonomousCanvasGroup.alpha = 1;
        autonomousCanvasGroup.interactable = true;
        autonomousCanvasGroup.blocksRaycasts = true;

        teleOpCanvasGroup.alpha = 0;
        teleOpCanvasGroup.interactable = false;
        teleOpCanvasGroup.blocksRaycasts = false;

        endGameCanvasGroup.alpha = 0;
        endGameCanvasGroup.interactable = false;
        endGameCanvasGroup.blocksRaycasts = false;

        submitDataCanvasGroup.alpha = 0;
        submitDataCanvasGroup.interactable = false;
        submitDataCanvasGroup.blocksRaycasts = false;
    }

    public void TeleOpButton()
    {
        mainCanvasGroup.alpha = 0;
        mainCanvasGroup.interactable = false;
        mainCanvasGroup.blocksRaycasts = false;

        initalDataCanvasGroup.alpha = 0;
        initalDataCanvasGroup.interactable = false;
        initalDataCanvasGroup.blocksRaycasts = false;

        autonomousCanvasGroup.alpha = 0;
        autonomousCanvasGroup.interactable = false;
        autonomousCanvasGroup.blocksRaycasts = false;

        teleOpCanvasGroup.alpha = 1;
        teleOpCanvasGroup.interactable = true;
        teleOpCanvasGroup.blocksRaycasts = true;

        endGameCanvasGroup.alpha = 0;
        endGameCanvasGroup.interactable = false;
        endGameCanvasGroup.blocksRaycasts = false;

        submitDataCanvasGroup.alpha = 0;
        submitDataCanvasGroup.interactable = false;
        submitDataCanvasGroup.blocksRaycasts = false;
    }

    public void EndGameButton()
    {
        mainCanvasGroup.alpha = 0;
        mainCanvasGroup.interactable = false;
        mainCanvasGroup.blocksRaycasts = false;

        initalDataCanvasGroup.alpha = 0;
        initalDataCanvasGroup.interactable = false;
        initalDataCanvasGroup.blocksRaycasts = false;

        autonomousCanvasGroup.alpha = 0;
        autonomousCanvasGroup.interactable = false;
        autonomousCanvasGroup.blocksRaycasts = false;

        teleOpCanvasGroup.alpha = 0;
        teleOpCanvasGroup.interactable = false;
        teleOpCanvasGroup.blocksRaycasts = false;

        endGameCanvasGroup.alpha = 1;
        endGameCanvasGroup.interactable = true;
        endGameCanvasGroup.blocksRaycasts = true;

        submitDataCanvasGroup.alpha = 0;
        submitDataCanvasGroup.interactable = false;
        submitDataCanvasGroup.blocksRaycasts = false;
    }

    public void SubmitDataButton()
    {
        mainCanvasGroup.alpha = 0;
        mainCanvasGroup.interactable = false;
        mainCanvasGroup.blocksRaycasts = false;

        initalDataCanvasGroup.alpha = 0;
        initalDataCanvasGroup.interactable = false;
        initalDataCanvasGroup.blocksRaycasts = false;

        autonomousCanvasGroup.alpha = 0;
        autonomousCanvasGroup.interactable = false;
        autonomousCanvasGroup.blocksRaycasts = false;

        teleOpCanvasGroup.alpha = 0;
        teleOpCanvasGroup.interactable = false;
        teleOpCanvasGroup.blocksRaycasts = false;

        endGameCanvasGroup.alpha = 0;
        endGameCanvasGroup.interactable = false;
        endGameCanvasGroup.blocksRaycasts = false;

        submitDataCanvasGroup.alpha = 1;
        submitDataCanvasGroup.interactable = true;
        submitDataCanvasGroup.blocksRaycasts = true;
    }
}
