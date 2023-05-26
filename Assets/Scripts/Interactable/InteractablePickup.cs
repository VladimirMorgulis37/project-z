using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePickup : MonoBehaviour
{
    private bool isInRange;

    public PlayerInventory playerInventory;

    public Item key;
    public Item gazirovka;
    private Material material;

    public int id;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isInRange = true;
            playerInventory = collision.GetComponent<PlayerInventory>();
            material.SetFloat("_OutlineThickness", 0.5f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerInventory.uiInteractionKey.SetActive(false);
            isInRange = false;
            material.SetFloat("_OutlineThickness", 0f);
        }
    }
    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        key = new Item { itemType = Item.ItemType.Key, id = 102 };
        gazirovka = new Item { itemType = Item.ItemType.Gazirovka, id = 101 };
    }
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                switch (id)
                {
                    default:break;
                    case 101:
                        playerInventory.GiveStudak(gazirovka);
                        break;
                    case 102:
                        playerInventory.GiveStudak(key);
                        break;
                }
                Destroy(gameObject);
            }

        }
    }
}
