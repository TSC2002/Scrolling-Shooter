using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDelJugador : MonoBehaviour
{
    public float runSpeed = 2;

    public float jumpSpeed = 3;

    Rigidbody2D rb2D;

    bool floorDetected = false;
    bool isJump = false;
    public float jumpForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
        }

        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
        }

        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y); 
        }

        Vector2 floor = transform.TransformDirection(Vector2.down);

        if (Physics2D.Raycast(transform.position, floor, 1.0f))
        {
            floorDetected = true;
            print("Contacto con el suelo");
        }
        else
        {
            floorDetected = false;
            print("No hay contacto con el suelo");
        }

        isJump = Input.GetButtonDown("Jump");

        if (isJump)
        {
            rb2D.AddForce(new Vector3(0, jumpForce, 0 ), ForceMode2D.Impulse);
        }

    }
}
