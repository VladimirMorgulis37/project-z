using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 startPos;

    public bool usable = false;

    public int id;

    public Transform player;
    //public Message message;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        startPos = transform.position;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        if (usable)
        {
            ResetPos();
            //message.Create(player, new Vector3(1f, 0f, 0f), "Блядина ебаная ну ПОДУМАЙ хоть немного!!!!");
        }
        canvasGroup.blocksRaycasts = true;
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Это случилось");
    }

    void ResetPos()
    {
        transform.position = startPos;
    }
}
