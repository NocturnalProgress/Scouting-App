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

    void Start()
    {
        mainCanvas.rootCanvas.enabled = true;
        initialDataCanvas.rootCanvas.enabled = false;
        autonomousCanvas.rootCanvas.enabled = false;
        teleOpCanvas.rootCanvas.enabled = false;
        endGameCanvas.rootCanvas.enabled = false;
        submitDataCanvas.rootCanvas.enabled = false;
    }

    public void MainButton()
    {
        mainCanvas.rootCanvas.enabled = true;
        initialDataCanvas.rootCanvas.enabled = false;
        autonomousCanvas.rootCanvas.enabled = false;
        teleOpCanvas.rootCanvas.enabled = false;
        endGameCanvas.rootCanvas.enabled = false;
        submitDataCanvas.rootCanvas.enabled = false;
    }

    public void InitalDataButton()
    {
        mainCanvas.rootCanvas.enabled = false;
        initialDataCanvas.rootCanvas.enabled = true;
        autonomousCanvas.rootCanvas.enabled = false;
        teleOpCanvas.rootCanvas.enabled = false;
        endGameCanvas.rootCanvas.enabled = false;
        submitDataCanvas.rootCanvas.enabled = false;
    }

    public void AutonomousButton()
    {
        mainCanvas.rootCanvas.enabled = false;
        initialDataCanvas.rootCanvas.enabled = false;
        autonomousCanvas.rootCanvas.enabled = true;
        teleOpCanvas.rootCanvas.enabled = false;
        endGameCanvas.rootCanvas.enabled = false;
        submitDataCanvas.rootCanvas.enabled = false;
    }

    public void TeleOpButton()
    {
        mainCanvas.rootCanvas.enabled = false;
        initialDataCanvas.rootCanvas.enabled = false;
        autonomousCanvas.rootCanvas.enabled = false;
        teleOpCanvas.rootCanvas.enabled = true;
        endGameCanvas.rootCanvas.enabled = false;
        submitDataCanvas.rootCanvas.enabled = false;
    }

    public void EndGameButton()
    {
        mainCanvas.rootCanvas.enabled = false;
        initialDataCanvas.rootCanvas.enabled = false;
        autonomousCanvas.rootCanvas.enabled = false;
        teleOpCanvas.rootCanvas.enabled = false;
        endGameCanvas.rootCanvas.enabled = true;
        submitDataCanvas.rootCanvas.enabled = false;
    }

    public void SubmitDataButton()
    {
        mainCanvas.rootCanvas.enabled = false;
        initialDataCanvas.rootCanvas.enabled = false;
        autonomousCanvas.rootCanvas.enabled = false;
        teleOpCanvas.rootCanvas.enabled = false;
        endGameCanvas.rootCanvas.enabled = false;
        submitDataCanvas.rootCanvas.enabled = true;
    }
}
