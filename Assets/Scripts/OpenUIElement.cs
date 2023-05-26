using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUIElement : MonoBehaviour
{
    public GameObject UI;

    public void OpenUi()
    {
        UI.SetActive(true);
    }
}
