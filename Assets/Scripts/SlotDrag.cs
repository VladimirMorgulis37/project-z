using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotDrag : MonoBehaviour, IDropHandler
{
    public int id;
    public GameObject cutscene;
    public GameObject teleport;
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        //Debug.Log("Item Dropped");
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.GetComponent<DragAndDrop>().id == id) 
            {
                switch (id)
                {
                    default:break;
                    case 100:
                        Destroy(gameObject.GetComponent<BoxCollider2D>());
                        gameObject.GetComponent<Animator>().SetBool("prohod", true);
                        break;
                    case 101:
                        cutscene.SetActive(true);
                        break;
                    case 102:
                        teleport.SetActive(true);
                        break;


                }
                Debug.Log("Correct!!!!");
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                //eventData.pointerDrag.GetComponent<DragAndDrop>().isFoundSmth = true;
            }

            
        }
    }
}
