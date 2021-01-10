using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speedX;
    public float speedY;
    private bool ballLaunched = false;

    void Start()
    {
        speedX = 0;
        speedY = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ballLaunched)
        {
            BallStartThorw();
        }
        this.transform.Translate(speedX, speedY, 0);
    }

    public void BallStartThorw()
    {
        float x = Random.Range(-1f, 1f);

        speedX = x * Time.deltaTime;
        speedY = (1 - Mathf.Abs(x) )* Time.deltaTime;
        ballLaunched = true;
    }
}
