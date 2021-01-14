using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasketMovement : MonoBehaviour
{
    public float xSpeed ;
    private Touch touch;
    public float xSpeedPc = 0.1f ;


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.01f ;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(); // keyboard Movement
        SwipeMovement(); //Touch Movement
        // limits x move
        transform.position = new Vector3(Mathf.Clamp(transform.position.x ,-1.5f ,1.5f ) ,transform.position.y ,transform.position.z);
    }  

    void Move()
    {
       if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(xSpeedPc * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(xSpeedPc * Time.deltaTime, 0, 0);
        }
    }

    void SwipeMovement()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

             
                if(touch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * xSpeed ,
                    transform.position.y, transform.position.z);
                }
                

        }
    }
}
