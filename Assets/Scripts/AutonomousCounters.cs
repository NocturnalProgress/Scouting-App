using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class AutonomousCounters : MonoBehaviour
{
    // [HideInInspector]

    public int innerCount;
    public int innerInnerCount;
    public int outerCount;

    [HideInInspector] public TMP_Text innerCounter;
    [HideInInspector] public TMP_Text innerInnerCounter;
    [HideInInspector] public TMP_Text outerCounter;

    [HideInInspector] public Button subtractInnerCounter;
    [HideInInspector] public Button addInnerCounter;
    [HideInInspector] public Button subtractInnerInnerCounter;
    [HideInInspector] public Button addInnerInnerCounter;
    [HideInInspector] public Button subtractOuterCounter;
    [HideInInspector] public Button addOuterCounter;

    void Start()
    {
        innerCount = Convert.ToInt32(innerCounter.text);
        innerInnerCount = Convert.ToInt32(innerInnerCounter.text);
        outerCount = Convert.ToInt32(outerCounter.text);
    }

    //Inner
    public void SubtractFromInnerCounter()
    {
        innerCount = innerCount - 1;
        UpdateInnerCount();
    }

    public void AddToInnerCounter()
    {
        innerCount = innerCount + 1;
        UpdateInnerCount();
    }

    //InnerInner
    public void SubtractFromInnerInnerCounter()
    {
        innerInnerCount = innerInnerCount - 1;
        UpdateInnerInnerCount();
    }

    public void AddToInnerInnerCounter()
    {
        innerInnerCount = innerInnerCount + 1;
        UpdateInnerInnerCount();
    }

    //Outer
    public void SubtractFromOuterCounter()
    {
        outerCount = outerCount - 1;
        UpdateOuterCount();
    }

    public void AddToOuterCounter()
    {
        outerCount = outerCount + 1;
        UpdateOuterCount();
    }

    private void UpdateInnerCount()
    {
        innerCounter.text = innerCount.ToString();
    }

    private void UpdateInnerInnerCount()
    {
        innerInnerCounter.text = innerInnerCount.ToString();
    }

    private void UpdateOuterCount()
    {
        outerCounter.text = outerCount.ToString();
    }

}
