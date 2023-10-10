using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{

    Animator a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            a.SetTrigger("Walk");
            
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            a.SetTrigger("Walk");

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            a.SetTrigger("Walk");

        }

         if(Input.GetKeyDown(KeyCode.D))
        {
            a.SetTrigger("Walk");
            
        }

        if (Input.GetKeyDown(KeyCode.None))
        {
            a.SetTrigger("Idle");

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            a.SetTrigger("Jump");

        }
    }
}
