using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variable for unity
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sets the horizontal keys(A,D,Left,Right) to the x movement
        movement.x = Input.GetAxisRaw("Horizontal");
        //sets the vertical keys(W,S,Up,Down) to the y movement
        movement.y = Input.GetAxisRaw("Vertical");

        //sets the variable for the animator in unity depending on the movement
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        //actual movement of character is being done here to avoid frame rate issues
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D colll)
    {
        if (colll.gameObject.tag == "Player")
        {
            print("HIT");
        }
    }
}
