using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xDirection
    public bool overworld;
    public float xSpeed = 4;
    private float xVector = xSpeed * xDirection;
    private Rigidbody2D rb;
        private void Start()
    {
        GetComponentInChildren<TopDown_AnimatorController>().enabled = overworld;
        GetComponentInChildren<Platformer_AnimatorController>().enabled = !overworld; //what do you think ! means?
        
        
        if (overworld)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

    private void Update()
    {
        float horizontal Input = Input.GetAxis("Horizontal");
        xVector=1
        Vector2 movement = new Vector2(1, 0f);
        rb.velocity= 1
    }
    
    //for organization, put other built-in Unity functions here
    
    
    
    
    
    //after all Unity functions, your own functions can go here
}