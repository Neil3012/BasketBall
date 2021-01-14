using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaEffect : MonoBehaviour
{
    public static ParabolaEffect  current;
  public GameObject ballToSpawn;
	public int damage = 1;
    //public float lifeTime;
    //public int health = 3;




    Vector3 _rs = new Vector3();
    Rigidbody _basketBall;
    

    Vector3 _distance, _distanceX_Z,_result, _velOfBall;
    float _y,_xz;
    float _velX,_velY;
    Camera cam;
    public LayerMask layer; RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
    current=this;
    }    

    // Update is called once per frame
    void Update()
    {
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100))
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.black);
        //    _rs = hit.point;
        //    Debug.Log(" Name " + hit.ToString());
        //}

    }

    public Vector3 VelocityCheck(Vector3 target,Vector3 origin,float time)   
    {
        _distance=target-origin;
        _distanceX_Z=_distance;
        _distanceX_Z.z=0;
        _y=_distance.y;
        _xz=_distanceX_Z.magnitude;
        _velX=_xz/time;
         _velY=_y/time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;
         _result=_distanceX_Z.normalized;
         _result*=_velX;
         _result.y=_velY;
         return _result;
    }
    Vector3 getRandomTargetPos()
	{
		float _x = Random.Range (-4, 5);
		float _y = Random.Range (4, 5);
		float _z = -22f;
		Vector3 newPos = new Vector3 (_x, _y, _z);
		return newPos;
	}


    public void LaunchBall(Rigidbody r,Vector3 rs){
     //Ray camRay= cam.ScreenPointToRay(Input.mousePosition);
         //RaycastHit hit;
        // if(Physics.Raycast(camRay,out hit,1000f,layer)){

        // print ("Name of Object "+hit.collider.name);
       // if(r!=null)
        {
         _velOfBall=VelocityCheck(rs,transform.position,1f);
        // if(Input.GetMouseButtonDown(0)){
         //Rigidbody rb=Instantiate (_basketBall, getRandomPos(), Quaternion.identity);
   
         r.velocity=_velOfBall;
        }


       Vector3 GetTarget()
        {
          
            if (Input.GetMouseButtonDown(0))
            {
                
                if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit, 100))
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)* hit.distance, Color.black);
                     _rs = hit.point;
                    Debug.Log(" Name " + hit.ToString());
                }
                
            }
            return _rs;
        }
}






#region  Dummy

	// Vector3 getRandomPos()
	// {
	// 	float _x = Random.Range (-2, 3);
	// 	float _y = Random.Range (2, 8);
	// 	float _z = -15f;
	// 	Vector3 newPos = new Vector3 (_x, _y, _z);
	// 	return newPos;
	// }
	// void SpawnNow() 
	// {
    //     Ray camRay= cam.ScreenPointToRay(Input.mousePosition);
    //     RaycastHit hit;
    //     if(Physics.Raycast(camRay,out hit,1000f,layer)){

    //     print ("Name of Object "+hit.collider.name);
    //     _velOfBall=VelocityCheck(hit.point,transform.position,1f);
    //     if(Input.GetMouseButtonDown(0)){
    //     Rigidbody rb=Instantiate (_basketBall, getRandomPos(), Quaternion.identity);
    
    //     rb.velocity=_velOfBall;
    // }

    // }
		
	// }
	// void OnTriggerEnter(Collider other)
	// {
	// 	if(other.CompareTag("Enemy"))
	// 	{
	// 		other.GetComponent<DestroyByTime>().health -= damage;
	// 		Debug.Log(other.GetComponent<DestroyByTime>().health);
	// 		Destroy(gameObject);
			
	// 	}
	// }
  
	// void Start () {
	// 	InvokeRepeating ("SpawnNow", 2,60*60);
	// 	cam=Camera.main;
		
	// }
#endregion
}
