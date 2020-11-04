using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private bool moveLeft;
    private bool moveRight;
    private bool moveForward;
    private bool moveBackward;
    private float horizontalMove;
    private float verticalMove;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveLeft = false;
        moveRight = false;
        moveForward = false;
        moveBackward = false;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }
    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }
    public void PointerDownForward()
    {
        moveForward = true;
    }
    public void PointerUpForward()
    {
        moveForward = false;
    }
    public void PointerDownBackward()
    {
        moveBackward = true;
    }
     public void PointerUpBackward()
    {
        moveBackward = false;
    }


    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }
    private void MovementPlayer()
    {
        if(moveLeft)
        {
            horizontalMove = -speed;
        }
        else if(moveRight)
        {
            horizontalMove = speed;
        }
        else if(moveForward)
        {
            verticalMove = speed;
        }
        else if(moveBackward)
        {
            verticalMove = -speed;
        }
        else
        {
            horizontalMove = 0;
            verticalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalMove,rb.velocity.y);
        rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,verticalMove);
    }
}
