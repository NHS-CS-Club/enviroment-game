using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTester : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRunning;
    public Animator playerAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            isRunning = true;
            Debug.Log("space");
        }
        else
        {
            isRunning = false;
        }
        playerAnimator.SetBool("isRunning",isRunning);
    }
}
