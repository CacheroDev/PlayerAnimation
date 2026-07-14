using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] public float horizontal;
    [SerializeField] float speed;
    [SerializeField] public bool isRunning;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
         
        if (horizontal > 0f)
        {
            transform.localScale = Vector2.one;
            isRunning = true;
        }
        else if (horizontal < 0f)
        {
            transform.localScale = new Vector2(-1, 1);
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
            
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
