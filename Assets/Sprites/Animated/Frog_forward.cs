using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog_forward : MonoBehaviour
{
    private Animator mAnimator;

    private void Awake()
    {
        mAnimator = GetComponent<Animator>();
    }
    //void Start()
    //{
    //}

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                mAnimator.SetTrigger("Forward");
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                {
                    mAnimator.SetTrigger("stop");
                }
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                mAnimator.SetTrigger("Forward");
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                {
                    mAnimator.SetTrigger("stop");
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                mAnimator.SetTrigger("Forward");
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                {
                    mAnimator.SetTrigger("stop");
                }
            }
        }

    }
}
