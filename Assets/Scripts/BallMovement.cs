using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rigid;
    public int ballSpeedForward;
    public int ballSpeedHorizontal;
    public int ballTork;

    void Start()
    {
        rigid=GetComponent<Rigidbody>();
       
    }

    
    void FixedUpdate()
    {
        if(!GameManager._Instance.gameOver)
        {
           
            float horizontalMove=Input.GetAxis("Horizontal");
            Vector3 move=new Vector3(horizontalMove*ballSpeedHorizontal,0.0f,45);
            rigid.AddForce(move);
                    
        }
        
    }
}
