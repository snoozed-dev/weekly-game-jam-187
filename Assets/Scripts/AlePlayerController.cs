using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlePlayerController : MonoBehaviour
{
    public float accelerationRate = 10;
    public float deccelerationRate = 10;
    public float topSpeed = 10;

    public float turnSpeed = 2;
    float currentDecceleration;
    public float currentSpeed = 0;
    public float horizontalInput = 0;
    float verticalInput = 0;
    void Start()
    {

    }

    void Update()
    {

        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(verticalInput) > 0)
        {
            currentSpeed += verticalInput * accelerationRate * Time.deltaTime;
        }
        else
        {
            currentSpeed = Mathf.SmoothDamp(currentSpeed, 0, ref currentDecceleration, 50 * Time.deltaTime);
        }
        currentSpeed = Mathf.Clamp(currentSpeed, -topSpeed, topSpeed);
        MoveCar();
    }


    void MoveCar()
    {
        float turnMultiplier = Mathf.Abs(Mathf.Abs(currentSpeed) - topSpeed);
        if (Mathf.Abs(currentSpeed) > 0)
        {
            transform.Rotate(transform.up, horizontalInput * turnSpeed * turnMultiplier * ((verticalInput < 0) ? -1 : 1) * Time.deltaTime);
        }
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

}
