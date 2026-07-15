using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScaler : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.gravityScale = 3;
        }
        else
        {
            rb.gravityScale = 2;
        }
    }
}
