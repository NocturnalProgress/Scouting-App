using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/*
    This script allows the user to swipe between different menus.
    The scroll speed and other variables can be controlled here.
*/

public class PageSwiper : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 panelLocation;

    private float percentThreshold = 0.2f;
    private float easing = 0.1f;

    private int totalPages = 7;
    private int currentPage = 1;

    private HorizontalLayoutGroup horizontalLayoutGroup;

    private RectTransform canvasHolderRectTransform;
    private RectTransform maimMenuRectTransform;

    // Start is called before the first frame update
    private void Start()
    {
        panelLocation = transform.position;

        horizontalLayoutGroup = GetComponent<HorizontalLayoutGroup>();
        canvasHolderRectTransform = GetComponent<RectTransform>();

        maimMenuRectTransform = GetComponent<RectTransform>();

        if ((UnityEngine.iOS.Device.generation.ToString()).IndexOf("iPad") > -1)
        {
            Debug.Log("iPad");
            horizontalLayoutGroup.padding.right = -2525;
            LayoutRebuilder.MarkLayoutForRebuild(canvasHolderRectTransform);
        }
        else
        {
            // horizontalLayoutGroup.padding.right = -1717;
        }
    }

    public void OnDrag(PointerEventData data)
    {
        float difference = data.pressPosition.x - data.position.x;
        transform.position = panelLocation - new Vector3(difference, 0, 0);
    }

    public void OnEndDrag(PointerEventData data)
    {
        float percentage = (data.pressPosition.x - data.position.x) / Screen.width;
        if (Mathf.Abs(percentage) >= percentThreshold)
        {
            Vector3 newLocation = panelLocation;
            if (percentage > 0 && currentPage < totalPages)
            {
                currentPage++;
                newLocation += new Vector3(-Screen.width, 0, 0);
            }
            else if (percentage < 0 && currentPage > 1)
            {
                currentPage--;
                newLocation += new Vector3(Screen.width, 0, 0);
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;
        }
        else
        {
            StartCoroutine(SmoothMove(transform.position, panelLocation, easing));
        }
    }

    private IEnumerator SmoothMove(Vector3 startpos, Vector3 endpos, float seconds)
    {
        float t = 0f;
        while (t <= 1.0)
        {
            t += Time.deltaTime / seconds;
            transform.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }

    public void ReturnToInitalData()
    {
        while (currentPage != 1)
        {
            Vector3 newLocation = panelLocation;
            currentPage--;
            newLocation += new Vector3(Screen.width, 0, 0);
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;
            currentPage--;
        }
    }
}