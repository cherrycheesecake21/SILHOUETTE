using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Establishing an object to call.
    public  Rigidbody rb;

    // Establishing float values.
    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;
    public float RotateSpeed = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Here we are storing the value of the horizontal and vertical inputs.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //And here we call the rotate speed as we rotate the player, based on input.
        transform.Rotate(Vector3.up * horizontalInput * RotateSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * verticalInput * RotateSpeed * Time.deltaTime);

        // Here we are calling the player's input.
        if (Input.GetKey("s"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
    }
}
