﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float horizontalSpeed;
    float speedX;
    public float verticalImpulse;
    Rigidbody2D rb;
    KeyCode keyLeft = KeyCode.A;
    KeyCode keyRight = KeyCode.D;
    KeyCode keyJump = KeyCode.W;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey(keyLeft))
        {
            speedX = -horizontalSpeed;
        }
        else if (Input.GetKey(keyRight))
        {
            speedX = horizontalSpeed;
        }

        if (Input.GetKeyDown(keyJump))
        {
            rb.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);
        }

        transform.Translate(speedX, 0, 0);
        speedX = 0;
    }
}
