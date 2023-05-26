using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CutSceneText : MonoBehaviour
{
    public string[] text;
    private TextMeshProUGUI tmPro;
    // Start is called before the first frame update
    void Start()
    {
        tmPro = GetComponent<TextMeshProUGUI>();
        tmPro.text = "123";
        StartCoroutine(startMessage());
    }

    IEnumerator startMessage()
    {
        for(int i  = 0; i < text.Length; i++)
        {
            tmPro.text = text[i];
            yield return new WaitForSeconds(5);
        }
    }
}
