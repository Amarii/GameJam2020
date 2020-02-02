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
    public int IngredientNumber;
    public string NewIngredient;
    public Vector3 InventoryPlayerPos;

    Vector2 Inventory;
    GameObject Banana;
    GameObject Croissant;
    GameObject InventoryBox;
    GameObject InventoryBox2;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        Banana = Instantiate(GameObject.Find("Banana"));
        Croissant = Instantiate(GameObject.Find("Croissant"));
        IngredientNumber = 0;
        InventoryPlayerPos = new Vector3(-3, -2, 2);
        InventoryBox = Instantiate(GameObject.Find("Inventory"));
        InventoryBox2 = GameObject.Find("Inventory");
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
        Inventory = InventoryBox.GetComponent<InventoryCode>().Inventorypos;
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.Z))
        {
            InventoryPlayerPos = new Vector3(transform.position.x, transform.position.y, -4);
        }
        
        if (colll.gameObject.tag == "Ingredient" && Input.GetKey(KeyCode.X))
        {
            InventoryPlayerPos = new Vector3(Inventory.x, Inventory.y - 1, -4);
            IngredientNumber += 1;
        }
        
    }

    

}
