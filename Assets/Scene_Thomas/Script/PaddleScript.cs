using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public int playerId;

    Rigidbody2D rb;
    public float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(playerId == 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= transform.right * (Time.deltaTime * speed);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += transform.right * (Time.deltaTime * speed);
            }
        }
        else if(playerId == 1)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                transform.position -= transform.right * (Time.deltaTime * speed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += transform.right * (Time.deltaTime * speed);
            }
        }
    }
}
