using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform targetPlayer;
    public Vector3 offset;
    [Range(1, 10)]
    public float SmoothFactor;
    private void FixedUpdate()
    {
        Follow();
    }
    void Follow()
    {

        Vector3 targetPos = targetPlayer.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position,targetPos,SmoothFactor*Time.fixedDeltaTime);
        transform.position = smoothedPos;
    }
}
