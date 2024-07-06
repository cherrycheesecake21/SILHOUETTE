using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 8.0f;
    private Rigidbody m_Rb;
    private float m_SpeedModifier = 1f;

    void Awake()
    {
        m_Rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 playertPos = m_Rb.position;
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized;

        if (movement == Vector3.zero )
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(movement);

        targetRotation = Quaternion.RotateTowards(
        transform.rotation, targetRotation, 360 * Time.fixedDeltaTime );

        m_Rb.MovePosition(m_Rb.position + movement * m_SpeedModifier * Time.fixedDeltaTime);
        m_Rb.MoveRotation(targetRotation);
    }
}
