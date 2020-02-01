using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //variable for unity
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    GameObject Inventory;
    GameObject Banana;
    float IngredientNumber;
    float InventoryNumber;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.Find("Inventory");
        Banana = GameObject.Find("Banana");
        InventoryNumber = 1;
        IngredientNumber = 0;
        
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
    private void OnCollisionEnter2D(Collision2D colll)
    {
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.Z))
        {
            colll.transform.position = new Vector3(transform.position.x, transform.position.y, -4);
            CreateBanana();


        }
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.X))
        {
            colll.transform.position = new Vector3(Inventory.transform.position.x, Inventory.transform.position.y-1, -4);
            IngredientNumber += 1;
            CreateInventory();


        }
        if (colll.gameObject.tag == "Creature" && Input.GetKey(KeyCode.Z))
        {
            print("GeGroet");
            
        }
    }
    private void OnCollisionStay2D(Collision2D colll)
    {
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.Z))
        {
            colll.transform.position = new Vector3(transform.position.x, transform.position.y, -4);
            CreateBanana();
        }
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.X))
        {
            colll.transform.position = new Vector3(Inventory.transform.position.x, Inventory.transform.position.y - 1, -4);
            IngredientNumber += 1;
            CreateInventory();


        }
    }

    //Create new stuff
    void CreateInventory () //new inventory
    {
        if (InventoryNumber < 4)
        {
            Inventory = Instantiate(Inventory);
            Inventory.transform.position = new Vector3(Inventory.transform.position.x + 2, Inventory.transform.position.y, 2);
            InventoryNumber += 1;
        }
    }
    void CreateBanana ()
    {
        Banana = Instantiate(Banana);
    }
}
