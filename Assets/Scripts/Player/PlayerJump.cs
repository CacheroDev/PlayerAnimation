using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] KeyCode jump;
    [SerializeField] float jumpForce;
    [SerializeField] bool jumpRequested;
    [SerializeField] FeetCollider feetCol;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        feetCol = GameObject.FindGameObjectWithTag("Feet").GetComponent<FeetCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jump) && feetCol.grounded)
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
