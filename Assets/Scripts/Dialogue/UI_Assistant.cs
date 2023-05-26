using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Assistant : MonoBehaviour
{
    //public GameObject text;
    private TextMeshPro messageText;
    // Start is called before the first frame update
    private void Awake()
    {
        messageText = transform.Find("message").Find("messageText").GetComponent<TextMeshPro>();
        //messageText = text.GetComponent<TextMeshProUGUI>();
        Debug.Log(messageText.text);
    }

    private void Start()
    { 
        messageText.text = "Hello world!";
        TextWriter.AddWriter_Static(messageText, "Чёрт, чёрт, чёрт, опять опаздываю! Нужно скорее бежать!", 0.05f, true, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
