using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_SkelAI : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = player.transform.position.x - transform.position.x;
        transform.position += new Vector3(x,0,0).normalized * moveSpeed * Time.deltaTime;
    }
}
