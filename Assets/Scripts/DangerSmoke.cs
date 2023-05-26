using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerSmoke : MonoBehaviour
{

    public float timer = 4;
    public Transform dangerSmoke;

    public ParticleSystem ps;
    public GameObject dying;

    private bool startedCorr = false;
    // Start is called before the first frame update
    void Start()
    {
        //ps.GetComponent<ParticleSystem>();
        ps.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timer);
        timer -= Time.deltaTime;
        if(timer < 0 && !startedCorr)
        {
            startedCorr = true;
            ps.Play();
            StartCoroutine(InjectorPrikolov());
        }
    }

    IEnumerator InjectorPrikolov()
    {
        dying.SetActive(true);
        
        yield return new WaitForSeconds(5);
        ps.Stop();
        dying.SetActive(false);
        timer = 4;
        startedCorr = false;
    }
}
