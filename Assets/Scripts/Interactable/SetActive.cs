using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject objectToActivate;

    public void SetObjectActive()
    {
        objectToActivate.SetActive(true);
    }

}
