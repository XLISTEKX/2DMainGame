using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot_Item_Drag : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform transformRect;
    
    CanvasGroup canvasGroup;
    Canvas canvas;

    private void Start()
    {
        canvas = GetComponentInParent<Canvas>();
        canvasGroup =  GetComponentInParent<CanvasGroup>();
        transformRect = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transformRect.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        resetPosition();
    }

    public void resetPosition()
    {
        transformRect.anchoredPosition = new Vector2(0, 0);
        canvasGroup.blocksRaycasts = true;
    }


}
