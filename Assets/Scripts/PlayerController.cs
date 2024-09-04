using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float yDirection;
    public float xDirection;
    public bool overworld;
    public float xSpeed;
    public float ySpeed;
    public float xVector;
    public float yVector;
    public Rigidbody2D rb;

    private void Start()
    {
        ySpeed = 4;
        xSpeed = 4;
        yDirection = 0;
        xDirection = 0;
        xVector = 0;
        yVector = 0;
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

    //Update runs once per frame
    private void Update()
    {
        yDirection = Input.GetAxis("Vertical");
        xDirection = Input.GetAxis("Horizontal");
        xVector = xSpeed * xDirection * Time.deltaTime;
        transform.Translate(new Vector3(xVector, yVector, 0));
        yVector = ySpeed * yDirection * Time.deltaTime;
    }
    
    //for organization, put other built-in Unity functions here
    
    
    
    
    
    //after all Unity functions, your own functions can go here
}