using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite studakSprite;
    public Sprite flashlightSprite;
    public Sprite prikolSprite;
    public Sprite keySprite;
    public Sprite gazirovkaSprite;
}
