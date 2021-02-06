using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AleCamaraController : MonoBehaviour
{
    enum POV { Player_POV };
    public Vector3 perspectiveDirection = new Vector3(12, 20, 0);
    public float perspectiveDistance = 20f;

    Vector3 currentVelocity;
    public GameObject player;

    public Camera mainCamera;
    POV currentPOV = POV.Player_POV;

    void Start()
    {
    }

    void Update()
    {
        FollowPOV();
    }

    Vector3 GetPespectiveVector()
    {
        return perspectiveDirection.normalized * perspectiveDistance;
    }

    void FollowPOV()
    {
        switch (currentPOV)
        {
            case POV.Player_POV:
                FollowPlayer();
                break;
            default:
                break;
        }
    }

    void FollowPlayer()
    {
        transform.position = player.transform.position;
        mainCamera.transform.position = Vector3.SmoothDamp(mainCamera.transform.position, transform.position + GetPespectiveVector(), ref currentVelocity, 20 * Time.deltaTime);
        mainCamera.transform.LookAt(mainCamera.transform.position - perspectiveDirection.normalized);
    }
}
