using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEffect : MonoBehaviour
{
    private bool _bounced;
    private float _bounceDirection;
    Vector3 _value;


    // Start is called before the first frame update
    void Start()
    {
        _bounced=false;
        _value=new Vector3(3,3,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_bounced)
        {
            transform.position=Vector3.Lerp(transform.position,
            new Vector3(_bounceDirection,transform.position.y,
            transform.position.z),Time.deltaTime*0.5f);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Basket")
        {
           _bounceDirection=Random.Range(-_value.x,_value.x);
           _bounced=true;
        }
    }


}
