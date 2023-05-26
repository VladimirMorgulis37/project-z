using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBox : MonoBehaviour
{
    private SpriteRenderer sr;
    private bool chngColor = false;
    public void ChangeColor()
    {
        sr = GetComponent<SpriteRenderer>();
        if (!chngColor)
        {
            sr.color = new Color(0, 0, 0);
            chngColor = true;
        }
        else
        {
            sr.color = new Color(255, 255, 255);
            chngColor = false;
        }
        
    }
}
