using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsgManager : MonoBehaviour
{
    public bool playerSays;
    public string text;
    public float offsetX;
    public float offsetY;
    public float lifeTime;

    //public Transform parent;

    private bool used = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !used)
        {
            if (playerSays)
            {
                Message.Create(collision.GetComponent<Transform>(), new Vector3(offsetX, offsetY, 0f), text, lifeTime);
            }
            else
            {
                Message.Create(gameObject.transform, new Vector3(offsetX, offsetY, 0f), text, lifeTime);
            }
            used = true;
        }
    }
}
