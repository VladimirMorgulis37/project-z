using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGiver : MonoBehaviour
{
    public CharacterController player;
    private void Awake()
    {
        player = GetComponent<CharacterController>();
    }

    public void GiveItem()
    {
        //player.inventory.AddItem(new Item { itemType = Item.ItemType.Flaslight, amount = 1 });
        //Debug.Log(player.inventory.GetItemList().Count);
    }
}
