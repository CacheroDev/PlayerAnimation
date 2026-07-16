using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer spriteRen;
    [SerializeField] PlayerShoot pShoot;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
        pShoot = GetComponent<PlayerShoot>();
    }

    void Update()
    {
        //Animation
        if (pShoot.shootRequested)
        {
            anim.Play("Shoot");
        }
        else if (rb.velocity.y > 0)
        {
            anim.Play("JumpUp");
        }
        else if (rb.velocity.y < 0)
        {
            anim.Play("JumpDown");
        }
        else if (rb.velocity.x != 0)
        {
            anim.Play("Run");
        }
        else
        {
            anim.Play("Idle");
        }

        //Facing right or left
        if (rb.velocity.x < 0)
        {
            spriteRen.flipX = true;
        }
        else if (rb.velocity.x > 0)
        {
            spriteRen.flipX = false;
        }
    }
}
