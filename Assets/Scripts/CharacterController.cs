using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;

    public bool canMove;

    private Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (canMove)
        {
            ProcessInputs();

            animator.SetFloat("Movement", moveDirection.sqrMagnitude);
            //Debug.Log(moveDirection.sqrMagnitude);

            if (moveDirection.x < 0 && !sr.flipX)
            {
                Flip();
            }
            if (moveDirection.x > 0 && sr.flipX)
            {
                Flip();
            }
        }
        else
        {
            animator.SetFloat("Movement", 0);
        }
        
    }

    private void FixedUpdate()
    {
        if(canMove)
        {
            
            rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        
    }

    void ProcessInputs()
    {
        if (canMove)
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            moveDirection = new Vector2(moveX, moveY).normalized;
        }
        
    }

    void Flip()
    {
        sr.flipX = !sr.flipX;
    }

}
