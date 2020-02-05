using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    public bool medicine;
  
    Vector2 movement;
    GameObject textBox;
    GameObject proxyinventory;

    float TimeCounter=0;                            //circular movement (Circle function)
    float collide = 0;                              // check if mole collides with player                                  
    // Start is called before the first frame update
    void Start()
    {
        textBox = Instantiate(GameObject.Find("Panel"));
        textBox.SetActive(false);
        proxyinventory = GameObject.Find("Inventory1");
        medicine = false;
       
}

    // Update is called once per frame
    void Update()
    {
        if(collide == 0)
        {
           // Circle();                               //creates a circular movement
        }
        else
        {

        }
       
        //sets the variable for the animator in unity depending on the movement
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    //void Circle()
    //{
    //    TimeCounter += Time.fixedDeltaTime;                     //Counting the time 
    //                                                            //Setting circular position coordinates of Mole    
    //    float PosX = Mathf.Cos(TimeCounter);
    //    float PosY = Mathf.Sin(TimeCounter);

    //    //Circular rotation
    //    transform.position = new Vector2(PosX, PosY);
    //}

    //Checks if objects collide
    private void OnCollisionStay2D(Collision2D collision)
    {
        collide = 1;
/*        CheckIngredients();    */                             //Check if there can be medicine or not
        
    }

    //Check if necessary ingredients are presents
    void CheckIngredients()
    {
        //if (Input.GetKey(KeyCode.Z))
        //{
        //    int i = 0;
        //    for (i=0;i<4;i++)
        //    {
        //        if (proxyinventory.GetComponent<InventoryCode>().name.Contains("Croissant"))
        //        {
        //            medicine = true;
        //        }
        //        else
        //        {
        //            medicine = false;
        //        }
        //    }
            

        //}
    }

}

