using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    private Rigidbody2D rig;
    private Animator anim;
    float moveH, moveV, speed = 5;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        MovePlayer();            
    }

    void MovePlayer()
    {
        moveH = moveJoystick.Horizontal;
        Vector2 dir = new Vector2(moveH, 0);
        rig.velocity = new Vector2(moveH * speed, 0);
    }
}
