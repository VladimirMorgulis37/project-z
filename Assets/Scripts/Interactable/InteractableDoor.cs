using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractableDoor : MonoBehaviour
{
    private bool isInRange;
    private bool isOpen;
    public PlayerInventory playerInventory;
    public Transform player;
    public Transform toPoint;

    public Item key;

    public GameObject canvas;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isInRange = true;
            player = collision.GetComponent<Transform>();
            playerInventory = collision.GetComponent<PlayerInventory>();

            playerInventory.uiInteractionKey.SetActive(true);

            if (playerInventory != null)
            {
                Debug.Log("Get component inventory");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerInventory.uiInteractionKey.SetActive(false);
            isInRange = false;
        }
    }
    void Awake()
    {
        key = new Item { itemType = Item.ItemType.Key, id = 102 };
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if(Input.GetKeyDown(KeyCode.E)) 
            {
                if(!isOpen)
                {
                    if (playerInventory.HasItem(key))
                    {
                        playerInventory.RemoveStudak();
                        Debug.Log("Ключ есть!");
                        isOpen = true;
                    }
                    else
                    {
                        Debug.Log("Ключа нет!");
                    }
                }
                else
                {
                    TeleportChell();
                    Debug.Log("Пошел нахуй!");
                }
            }
            
        }
    }


    void TeleportChell()
    {
        canvas.SetActive(true);
        player.position = new Vector2(toPoint.position.x, player.position.y);
    }
}
