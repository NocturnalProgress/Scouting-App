using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public void PowerPort(string color)
    {
        Debug.Log(color + " Power Port");
    }

    public void InitiationLine(string color)
    {
        Debug.Log(color + " Initiation Line");
    }

    public void Generator(string color)
    {
        Debug.Log(color + " Generator");


    }
}
