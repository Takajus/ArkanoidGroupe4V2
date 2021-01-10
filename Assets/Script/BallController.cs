using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speedX;
    public float speedY;
    private bool ballLaunched = false;
    private bool moveRight;
    private bool moveUp;
    private Rigidbody2D rb;

    void Start()
    {
        speedX = 0;
        speedY = 0;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ballLaunched)
        {
            BallStartThorw();
        }

        if(rb.velocity.x > 0)
        {
            moveRight = true;
        }
        else
        {
            moveRight = false;
        }

        if(rb.velocity.y > 0)
        {
            moveUp = true;
        }
        else
        {
            moveUp = false;
        }

        BallDirection();
    }

    public void BallStartThorw()
    {
        float x = Random.Range(0f, .8f);

        speedX = x *10;
        speedY = (1 - x) *10;
        rb.velocity = new Vector2(speedX, speedY);
        ballLaunched = true;
    }

    private void BallDirection()
    {
        float x;
        float y;
        if (moveRight)
        {
            x = speedX;
        }
        else
        {
            x = -speedX;
        }

        if (moveUp)
        {
            y = speedY;
        }
        else
        {
            y = -speedY;
        }
        rb.velocity = new Vector2(x, y);
    }
}
