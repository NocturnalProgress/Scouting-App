using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagement : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas powerPortCanvas;
    public Canvas initiationLineCanvas;
    public Canvas shieldGeneratorCanvas;

    public Canvas autonomousScoutingCanvas;
    public Canvas teleOpScoutingCanvas;


    void Start()
    {
        powerPortCanvas.rootCanvas.enabled = false;
        initiationLineCanvas.rootCanvas.enabled = false;
        shieldGeneratorCanvas.rootCanvas.enabled = false;
        mainMenuCanvas.rootCanvas.enabled = true;

        autonomousScoutingCanvas.enabled = true;
        teleOpScoutingCanvas.enabled = false;
    }

    public void DisplayPowerPortCanvas()
    {
        powerPortCanvas.rootCanvas.enabled = true;
        initiationLineCanvas.rootCanvas.enabled = false;
        shieldGeneratorCanvas.rootCanvas.enabled = false;
        mainMenuCanvas.rootCanvas.enabled = false;
    }

    public void DisplayInitiationLineCanvas()
    {
        powerPortCanvas.rootCanvas.enabled = false;
        initiationLineCanvas.rootCanvas.enabled = true;
        shieldGeneratorCanvas.rootCanvas.enabled = false;
        mainMenuCanvas.rootCanvas.enabled = false;
    }

    public void DisplayGeneratorCanvas()
    {
        powerPortCanvas.rootCanvas.enabled = false;
        initiationLineCanvas.rootCanvas.enabled = false;
        shieldGeneratorCanvas.rootCanvas.enabled = true;
        mainMenuCanvas.rootCanvas.enabled = false;
    }


    public void DisplayAutonomousPowerPortScouting()
    {
        autonomousScoutingCanvas.enabled = true;
        teleOpScoutingCanvas.enabled = false;
    }

    public void DisplayTeleOpPowerPortScouting()
    {
        autonomousScoutingCanvas.enabled = false;
        teleOpScoutingCanvas.enabled = true;
    }
}
