using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScaler : MonoBehaviour
{
    [SerializeField] float ascendGravity;
    [SerializeField] float descendGravity;
    [SerializeField] bool isDescending;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.y < 0)
        {
            isDescending = true;
        }
        else
        {
            isDescending = false;
        }
    }

    private void FixedUpdate()
    {
        if (isDescending)
        {
            rb.gravityScale = descendGravity;
        }
        else
        {
            rb.gravityScale = ascendGravity;
        }
    }
}
