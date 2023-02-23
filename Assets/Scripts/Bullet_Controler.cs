using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controler : MonoBehaviour
{
    Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(rb.velocity.magnitude >= 0.2f)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.right, rb.velocity);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


}
