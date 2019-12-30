using UnityEngine;

public class player2 : MonoBehaviour
{ // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float speed; 
    public float sidewaysForce = 500f;
    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {

        // add a forward force
       // rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        {
            if (Input.GetKey("f"))
                rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        {
            if (Input.GetKey("b"))
                rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey("r"))  // If the player is pressing the "r" key
        {         // Add a force to the right
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("l"))  // If the player is pressing the "l" key
        {        // Add a force to the left
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }

    }
}
    