using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public KeyCode interactKey;
    public UnityEvent eventType;

    private bool isInRange;
    private bool isInteractable;

    private Material material;

    public bool obvodka;

    void Start()
    {
        material = transform.parent.GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                eventType.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isInRange = true;
            if(obvodka)
            {
                material.SetFloat("_OutlineThickness", 0.5f);
            }
            
            //Debug.Log("is in range");
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isInRange = false;
            material.SetFloat("_OutlineThickness", 0f);
           // Debug.Log("is out of range");
        }
    }
}
