using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{
    public Transform before;
    public Transform after;

    private Item key;

    PlayerInventory inventory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inventory = collision.GetComponent<PlayerInventory>();
            if (inventory.HasItem(key))
            {
                collision.transform.position = after.position;
            }
            else
            {
                collision.transform.position = before.position;
            }
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        key = new Item { itemType = Item.ItemType.Key, id = 102 };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
