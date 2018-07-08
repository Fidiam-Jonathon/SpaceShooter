using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundry
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

    public float speed;
    public Boundry boundry;
    public float tilt;
    public GameObject shot;
    public Transform ShotSpawn;
    public float fireDelay;
    private float nextFire;

    private void Start()
    {
        speed     = 6;
        nextFire  = 0.0f;
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVertical = Input.GetAxis("Vertical")     * speed;

        Rigidbody rb = GetComponent<Rigidbody>();

        rb.rotation = Quaternion.Euler(0, 0, rb.velocity.x * -tilt);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement;

        rb.position = new Vector3
            (
            Mathf.Clamp(rb.position.x, boundry.xMin, boundry.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundry.zMin, boundry.zMax)
            );
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireDelay;
            Instantiate(shot, ShotSpawn.position, ShotSpawn.rotation);
            
        }
       
    }
}

