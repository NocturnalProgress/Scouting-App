﻿using UnityEngine;

/*
    This script keeps track of all panels and ensures that they are resized correctly.
*/

public class UIManager : MonoBehaviour
{
    public Canvas parentCanvas;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;

    private RectTransform parentRectTransform;

    // Start is called before the first frame update
    private void Start() // Resizes panels under PanelHolder based on screen size
    {
        parentRectTransform = parentCanvas.gameObject.GetComponent<RectTransform>();

        panel1.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel2.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel3.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel4.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel5.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel6.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel7.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
    }
}