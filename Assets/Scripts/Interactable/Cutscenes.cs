using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscenes : MonoBehaviour
{

    private Animator animator;
    private TextMeshProUGUI textMesh;
    public string[] text;

    public bool isPlayed = false;

    public GameObject fadeEffect;

    public bool levelTransition;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !isPlayed)
        {
            animator.SetBool("GameStarted", false);
            StartCoroutine(startMessage1());
            //other.GetComponent<CharacterController>().canMove = false;
            //animator.
        }
    }
    void Start()
    {
        animator = fadeEffect.GetComponent<Animator>();
        textMesh = fadeEffect.transform.Find("message").GetComponent<TextMeshProUGUI>();
    }

    IEnumerator startMessage1()
    {
        for (int i = 0; i < text.Length; i++)
        {
            textMesh.text = text[i];
            yield return new WaitForSeconds(2);
        }
        textMesh.text = "";
        animator.SetBool("GameStarted", true);
        if(levelTransition)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        isPlayed = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
