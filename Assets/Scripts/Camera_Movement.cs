using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private void Start()
    {
        target = GameObject.Find("Player");
    }
    private void FixedUpdate()
    {
        Vector3 destination = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * speed);

        transform.position = new Vector3(destination.x, destination.y, transform.position.z);        
    }
}
