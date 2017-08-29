using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("Run", true);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, 180);
            anim.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, 180);
            anim.SetBool("Run", false);
        }
    }
}
