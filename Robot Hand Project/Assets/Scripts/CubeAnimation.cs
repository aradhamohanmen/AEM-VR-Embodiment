using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    private Animator animator;
    private bool isAnimating = false;

    private void Start()
    {
       animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O) && !isAnimating)
        {
            animator.SetBool("IsAnimating", true);
            isAnimating = true;
        }
        else if (Input.GetKeyDown(KeyCode.O) && isAnimating)
        {
            animator.SetBool("IsAnimating", false);
            isAnimating = false;
        }
    }
}
