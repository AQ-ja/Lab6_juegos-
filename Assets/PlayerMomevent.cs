using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMomevent : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 1f;
    public float runSpeed = 40f;
    bool jump = false;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
