using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("move", true);
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("move", false);
        }
        
        
    }
}
