using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    protected float Animation;

    //Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       //ball1();
      
    }

    void ball1()
    {
        Animation += Time.deltaTime;

        Animation = Animation % 7f;   //  sec loop

        transform.localPosition = MathParabola.Parabola(Vector3.zero,Vector3.forward*-7f,2f,Animation/1f);

    }

}


