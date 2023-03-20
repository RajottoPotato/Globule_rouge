using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointDirection_Script : MonoBehaviour
{


    public Camera cam;
    public Rigidbody2D rb;

    Vector2 mousePos;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {


        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
