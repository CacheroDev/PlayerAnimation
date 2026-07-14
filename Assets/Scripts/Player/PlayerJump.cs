using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpForce;
    [SerializeField] KeyCode jump;
    [SerializeField] bool jumpRequested;
    //[SerializeField] public bool isJumping;
    [SerializeField] FeetCollision feetCol;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        feetCol = GameObject.FindGameObjectWithTag("Feet").GetComponent<FeetCollision>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jump) && feetCol.onGround)
        {
            jumpRequested = true;
        }
    }

    private void FixedUpdate()
    {
        if (jumpRequested)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpRequested = false;
        }
    }
}
