using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    private Animator anim;
    public bool Run;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Run", true);
        }
        anim.SetBool("Run", false);
    }
}
