using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Canvas parentCanvas;

    private RectTransform parentRectTransform;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;


    // Start is called before the first frame update
    void Start()
    {
        parentRectTransform = parentCanvas.gameObject.GetComponent<RectTransform>();

        panel1.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel2.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel3.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel4.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel5.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
        panel6.GetComponent<RectTransform>().sizeDelta = new Vector2(parentRectTransform.sizeDelta.x, parentRectTransform.sizeDelta.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
