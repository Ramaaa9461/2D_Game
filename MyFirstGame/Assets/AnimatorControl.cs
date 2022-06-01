using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    [SerializeField] float speed = 1;
    
    Animator animator;
    Vector2 lastDirection;
    Rigidbody2D body;
    Vector2 direction;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") );

      

        if (body.velocity.magnitude > 0)
        {
            lastDirection = body.velocity.normalized;
        }
        animator.SetFloat("Horizontal", lastDirection.x);
        animator.SetFloat("Vertical", lastDirection.y);
        animator.SetFloat("Speed", Vector2.ClampMagnitude(body.velocity, 1).magnitude); // direction.magnitude / maxVelocity 

    }

    private void FixedUpdate()
    {
        body.velocity = direction * speed;
    }
}
