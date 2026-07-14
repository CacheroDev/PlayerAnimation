using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;
    [SerializeField] PlayerController playerCon;
    [SerializeField] FeetCollision feetCol;
   

    void Start()
    {
        anim = GetComponent<Animator>();
        playerCon = GetComponent<PlayerController>();
        feetCol = GameObject.FindGameObjectWithTag("Feet").GetComponent<FeetCollision>();
    }


    void Update()
    {
        if (!feetCol.onGround)
        {
            anim.Play("PrincessJump");
        }
        else if (playerCon.horizontal != 0f)
        {
            anim.Play("PrincessRun");
        }
        else
        {
            anim.Play("PrincessIdle");
        }

    }
}
