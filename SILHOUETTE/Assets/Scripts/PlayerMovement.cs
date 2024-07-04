using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour {

    // Establishing an object to call.
    public  Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Here we are calling the player input and moving in that direction.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0f, 0.1f);
        }
    }
}
