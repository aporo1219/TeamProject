using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollter : MonoBehaviour
{
    //‚µ‚á‚ª‚Þ
    private Animator anim = null;

    //•à‚­
    private float STEP = 2.5f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        if (horizontalKey < 0)
        {
            anim.SetBool("squat", true);
        }
        else
        {
            anim.SetBool("squat", false);
        }

        //‰EŒü‚«
        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
    }
}