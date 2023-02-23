using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GroundCheck : MonoBehaviour
{
    Player_Movement pm;

    private void Start()
    {
        pm = GetComponentInParent<Player_Movement>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        pm.canJump = true;
    }
}
