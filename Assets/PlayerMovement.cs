using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    //variable for unity
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    //public int IngredientNumber;
    public string NewIngredient;
    public bool TakeItem;
    public bool FindItem;
    public string Item;
    public Vector2 ItemPos;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

        //IngredientNumber = 0;
        FindItem = false;
        TakeItem = false;
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

    //Functions for finding ingredients in objects
    private void OnCollisionStay2D(Collision2D colll)
    {
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.Z))
        {
            FindItem = true;
            Item = colll.gameObject.name;
            ItemPos = colll.transform.position;

        }
        
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.X))
        {
            TakeItem = true;
            Item = colll.gameObject.name;
            ItemPos = colll.transform.position;
        }
        
    }

    

}
