using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlePlayerController : MonoBehaviour
{
    public float accelerationRate = 20;
    public float topSpeed = 30;

    public float turnSpeed = 20;
    float currentSpeed = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(verticalInput) > 0)
        {
            currentSpeed += verticalInput * accelerationRate * Time.deltaTime;
            transform.Rotate(transform.up, horizontalInput * turnSpeed * verticalInput < 0 ? -1 : 1);
        }

    }

    void MoveCar()
    {

    }

}
