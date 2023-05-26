using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    public Transform itemSlotContainer;
    public Transform itemSlot;

    private void Awake()
    {
        //itemSlotContainer = transform.Find("ItemSlotContainer");
        //itemSlot = itemSlotContainer.Find("ItemSlot");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;

        inventory.onItemListChanged += Inventory_OnItemListChanged;

        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e)
    {
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach(Transform child in itemSlotContainer)
        {
            if (child == itemSlot) continue;
            Destroy(child.gameObject);
        }

        int x = 0;
        int y = 0;
        int offset = 0;
        float itemSlotCellSize = 25f;
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlot, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize + offset, y * itemSlotCellSize);

            offset += 11;

            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();

            image.GetComponent<DragAndDrop>().id = item.id;
            x++;
            if (x > 7)
            {
                x = 0;
                y++;
            }
        }
    }
}
