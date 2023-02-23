using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Player_Movement : MonoBehaviour
{
    public Joystick leftJoystick;

    public float speed = 1f;
    public float jumpForce = 1f;

    Rigidbody2D rigidbody2d;
    public bool canJump = true;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(leftJoystick.Horizontal != 0)
        {
            movePlayer(new Vector3(leftJoystick.Horizontal, 0));
        }
        if(leftJoystick.Vertical >= 0.5f)
        {
            jumpPlayer();
        }
       
    }

    void movePlayer(Vector3 direction)
    {
        //rigidbody2d.MovePosition(direction * Time.deltaTime * speed + transform.position);
        transform.position += direction * Time.deltaTime * speed;

        if(direction.x > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }

    void jumpPlayer()
    {
        if (canJump)
        {
            rigidbody2d.AddForce(transform.up * jumpForce * 100);
            canJump = false;
        }
    }
}
