using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Message : MonoBehaviour
{
    private TextMeshPro textMeshPro;
    //public Transform messageObj;

    public static void Create(Transform parent, Vector3 localPos, string text, float lifeTime)
    {
        Transform chatTransform = Instantiate(GameAssets.i.messageBubble, parent);
        chatTransform.localScale = new Vector3(1 / parent.localScale.x, 1 / parent.localScale.y, 1);
        chatTransform.localPosition = localPos;

        chatTransform.GetComponent<Message>().Setup(text);

        Destroy(chatTransform.gameObject, lifeTime);
    }
    private void Awake()
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
        //messageObj.Find("Text").GetComponent<TextMeshPro>();
    }
    

    private void Setup(string text)
    {
        textMeshPro.text = text;
        TextWriter.AddWriter_Static(textMeshPro, text, 0.01f, true, true);
    }
}
