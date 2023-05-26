using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopFinal : MonoBehaviour
{
    private Animator anim;
    public GameObject teleport;
    public GameObject lamp;
    public void LaptopTurnOn()
    {
        anim.SetTrigger("StarWorking");
        teleport.SetActive(true);
        lamp.SetActive(true);
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
}
