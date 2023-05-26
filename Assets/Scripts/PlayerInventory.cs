using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory ui_inventory;

    public GameObject uiInteractionKey;

    void Start()
    {
        inventory = new Inventory();
        inventory.AddItem(new Item { itemType = Item.ItemType.Studak, id = 100 });
        //inventory.AddItem(new Item { itemType = Item.ItemType.Studak, id = 100 });

        ui_inventory.SetInventory(inventory);
    }

    public void GiveStudak(Item item)
    {
        inventory.AddItem(item);
    }

    public void RemoveStudak()
    {
        Item Studak = inventory.GetItemList().Find(e => e.itemType == Item.ItemType.Key);
        if (Studak != null)
        {
            inventory.RemoveItem(Studak);
            Debug.Log("Долбоеб минус ключ");
        }
        
    }

    public bool HasItem(Item item)
    {
        return (inventory.GetItemList().Find(e => e.itemType == item.itemType) != null);
    }
}
