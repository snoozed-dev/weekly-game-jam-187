using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AleCamaraController : MonoBehaviour
{
    enum POV { Player_POV };
    public Vector3 perspectiveDirection;
    public float perspectiveDistance;
    public GameObject player;

    Camera mainCamera;
    POV currentPOV = POV.Player_POV;

    void Start()
    {
        mainCamera = GetComponentInChildren<Camera>();
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
        mainCamera.transform.LookAt(transform.position);
    }
}
