using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NicoPlayerController : MonoBehaviour
{
    public float forwardInput;
    public float horizontalInput;
    public float speed = 15.0f;
    public float turnSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveTruck();
       
    }


    //Move Player
    void MoveTruck()
    {

        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        bool shouldInvertRotation = Mathf.Abs(forwardInput) > 0 && forwardInput < 0;

        if (forwardInput > 0 || forwardInput < 0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed * (shouldInvertRotation ? -1 : 1));
        }

    }

}
