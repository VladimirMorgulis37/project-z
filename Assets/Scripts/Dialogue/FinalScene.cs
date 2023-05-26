using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScene : MonoBehaviour
{
    public int speechTime;

    public string[] texts;

    public float offsetX;
    public float offsetY;
    public GameObject cutscene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<CharacterController>().canMove = false;
            StartCoroutine(Dialogue());
        }
    }

    IEnumerator Dialogue()
    {
        for (int i = 0 ; i < texts.Length; i++)
        {
            Message.Create(gameObject.transform, new Vector3(offsetX, offsetY, 0f), texts[i], speechTime);
            yield return new WaitForSeconds(speechTime);
        }
        cutscene.SetActive(true);
    }
}
