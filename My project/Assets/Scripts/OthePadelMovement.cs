using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OthePadelMovement : MonoBehaviour
{
    //variable for movement
    public float speed = 20f;
    public float yBorder = 4.5f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < yBorder)    //when O is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);   //move up
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > -yBorder)    //when L is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed); //move down
        }
    }
}