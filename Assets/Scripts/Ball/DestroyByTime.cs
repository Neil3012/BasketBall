using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{

    //public float lifeTime;
   public int damage = 1; 
     public int health = 3;


    // Start is called before the first frame update
    void Start()
    {
        DestroyBall();
    }

    // Update is called once per frame
    void Update()
    { 
       
       
    }


    void DestroyBall()
    {
        if(gameObject.tag == "Object")
        {
            Destroy(gameObject,5f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            health -= damage;
          //  Debug.Log(other.GetComponent<SpawnCheck>().health);
            Destroy(gameObject);
            Debug.Log(gameObject.name);

        }
    }
}
