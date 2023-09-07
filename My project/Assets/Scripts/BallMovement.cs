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
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y);

        if (transform.position.x >= xBorder)
        {
            xSpeed = -xSpeed; //make it go left
        }
        if (transform.position.x <= -xBorder)
        {
            xSpeed *= -1;
        }
        //vertical movement
        transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up
        if (transform.position.y >= yBorder)
        {
            ySpeed = -ySpeed;
        }
        if (transform.position.y <= -yBorder)
        {
            ySpeed*= -1;
        }
    }
}