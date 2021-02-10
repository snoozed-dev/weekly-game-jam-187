using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlePlayerController : MonoBehaviour
{
    public float accelerationRate = 10;
    public float deccelerationRate = 10;
    public float topSpeed = 10;

    public float turnSpeed = 2;

    float currentTurn;
    float currentDecceleration;
    public float currentSpeed = 0;
    public float horizontalInput = 0;
    float verticalInput = 0;

    public bool isGrounded;

    public Vector3 a;
    public Vector3 b;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        CheckForGround();
        verticalInput = isGrounded ? Input.GetAxisRaw("Vertical") : 0f;
        horizontalInput = isGrounded ? Input.GetAxisRaw("Horizontal") : 0f;

        if (Mathf.Abs(verticalInput) > 0)
        {
            currentSpeed += verticalInput * accelerationRate * Time.fixedDeltaTime;
        }
        else
        {
            currentSpeed = Mathf.SmoothDamp(currentSpeed, 0, ref currentDecceleration, 50 * Time.fixedDeltaTime);
        }
        currentTurn = Mathf.Lerp(currentTurn, horizontalInput, 5f * Time.fixedDeltaTime);
        currentSpeed = Mathf.Clamp(currentSpeed, -topSpeed, topSpeed);
        MoveCar();
    }


    void MoveCar()
    {
        float turnMultiplier = Mathf.Abs(Mathf.Abs(currentSpeed) - topSpeed * 1.5f) * Mathf.Abs(currentSpeed * .5f);

        if (Mathf.Abs(currentSpeed) > 0)
        {
            transform.Rotate(Vector3.up, currentTurn * turnSpeed * turnMultiplier * ((currentSpeed < 0) ? -1 : 1) * Time.fixedDeltaTime);
        }
        rb.MovePosition(rb.position + Vector3.ProjectOnPlane(transform.forward, Vector3.up) * currentSpeed * Time.fixedDeltaTime);
    }

    void CheckForGround()
    {
        RaycastHit hit;
        Debug.DrawRay(rb.position, rb.rotation * -Vector3.up * 2, Color.red, 10);
        Physics.Raycast(rb.position, rb.rotation * -Vector3.up * 2, out hit, 2.5f);

        isGrounded = !!hit.collider;
        if (hit.collider)
        {
            //Debug.DrawLine(rb.position, hit.point, Color.red, 10);
        }
    }


}
