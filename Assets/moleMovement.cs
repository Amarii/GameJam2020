using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
  
    Vector2 movement;
    float TimeCounter=0;                            //circular movement (Circle function)
    float collide = 0;                              // check if mole collides with player                                  
    // Start is called before the first frame update
    void Start()
    {

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

    void Circle()
    {
        TimeCounter += Time.fixedDeltaTime;                     //Counting the time 
                                                                //Setting circular position coordinates of Mole    
        float PosX = Mathf.Cos(TimeCounter);
        float PosY = Mathf.Sin(TimeCounter);

        //Circular rotation
        transform.position = new Vector2(PosX, PosY);
    }

    //Checks if objects collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collide = 1;
    }

}

