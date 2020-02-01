using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
  
    Vector2 movement;
    float TimeCounter = 0;
    // Start is called before the first frame update
    void Start()
    {

}

    // Update is called once per frame
    void Update()
    {
        TimeCounter += Time.fixedDeltaTime;                     //Counting the time 
        //Setting circular position coordinates of Mole    
         float PosX = Mathf.Cos(TimeCounter);
         float PosY = Mathf.Sin(TimeCounter);
        float PosZ = 0;

        //Circular rotation
        transform.position = new Vector3(PosX, PosY, PosZ);

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
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            print("HITHIT");

        }
    }
}

