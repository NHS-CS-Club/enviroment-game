using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayerScript : MonoBehaviour
{
    public Transform followTarget;
    public float followSpeed = 5;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = followTarget.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (followTarget)
        {
            transform.position = followTarget.position - offset;
        }
    }
}
