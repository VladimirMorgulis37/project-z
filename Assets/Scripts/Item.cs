using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
   public enum ItemType
    {
        Studak,
        Flaslight,
        Prikol,
        Key,
        Gazirovka
    }
    public ItemType itemType;
    public int id;

    public Sprite GetSprite() 
    { 
        switch (itemType)
        {
            default:
            case ItemType.Studak:          return ItemAssets.Instance.studakSprite;
            case ItemType.Flaslight:       return ItemAssets.Instance.flashlightSprite;
            case ItemType.Prikol:          return ItemAssets.Instance.prikolSprite;
            case ItemType.Key:             return ItemAssets.Instance.keySprite;
                case ItemType.Gazirovka: return ItemAssets.Instance.gazirovkaSprite;
        }
    }
}
