using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //Variables for speed
    public float xSpeed = 0; //variable for x speed
    public float ySpeed = 0; //vaeiable for y speed

    //Variables for Bprders
    private float xBorder = 7.5f; //created a variable for horizontal border
    private float yBorder = 4.5f; //created a variable for vertical border

    //Variable for move state
    public bool xMove = true;
    public bool yMove = true;


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f;
        ySpeed = 0.0125f;
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal movement
        
        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right
        }
        else 
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); //move left
        }

        if (transform.position.x >= xBorder)
        {
            xMove = false; //make it go left
        }

        if (transform.position.x <= -xBorder)
        {
           xMove = true;
        }
        //vertical movement
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up
        }
        
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);
        }
        if (transform.position.y >= yBorder)
        {
            yMove = false;
        }
        if (transform.position.y <= -yBorder)
        {
           yMove = true;
        }
    }

    void onCollisionEnter2D(Collision2D collision) //when a collision happens
    {
        Debug.Log("hit");
        if (collision.collider.CompareTag("player"))
        {
            if (xMove == true)
            {
                xMove = false;
            }
            else if (xMove == false)
            {
                xMove = true;
            }
        }
    }
}