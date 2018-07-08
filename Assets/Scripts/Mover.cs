using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * speed;
    }
}
