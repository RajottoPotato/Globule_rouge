using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript_1 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(gameObject, 5f);
        
    }
}
