using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] Transform followingTarget;
    [SerializeField, Range(0f, 1f)] float parallaxStrength;
    [SerializeField] bool disableVerticalParallax;

    Vector3 targetPrevPos;

    void Start()
    {
        if (!followingTarget)
        {
            followingTarget = Camera.main.transform;
        }

        targetPrevPos = followingTarget.position;
    }

    void FixedUpdate()
    {
        var delta = followingTarget.position - targetPrevPos;

        if (disableVerticalParallax)
        {
            delta.y = 0;
        }
        targetPrevPos = followingTarget.position;

        transform.position += delta * parallaxStrength;
    }
}
