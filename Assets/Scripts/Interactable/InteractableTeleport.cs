using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTeleport : MonoBehaviour
{
    public Transform toPoint;
    public Transform player;
    public Animator transition;
    public int teleportTime = 1;

    public void TeleportPlayer()
    {

        StartCoroutine(Teleporter());
    }

    IEnumerator Teleporter()
    {
        transition.SetBool("Start", true);
        player.GetComponent<CharacterController>().canMove = false;
        yield return new WaitForSeconds (teleportTime);

        player.transform.position = toPoint.transform.position;

        transition.SetBool("Start", false);
        player.GetComponent<CharacterController>().canMove = true;
    }
}
