using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCheck : MonoBehaviour {

	public GameObject ballToSpawn;
	public int damage = 1;
	Vector3 _OP;
	//public float lifeTime;
	//public int health = 3;
	//void Start () {
	//	InvokeRepeating ("SpawnNow", 2,60*60);
	//	_OP=new Vector3();
		
	//}

	//private void Update()
	//{
	//	/* if(health <= 0)
 //       {
 //           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 //       } */

	//}
	
	//Vector3 getRandomPos()
	//{
	//	float _x = Random.Range (-2, 3);
	//	float _y = Random.Range (2, 8);
	//	float _z = -15f;
	//	Vector3 newPos = new Vector3 (_x, _y, _z);
	//	return newPos;
	//}
	//void SpawnNow()
	//{
	//	GameObject go=Instantiate (ballToSpawn, getRandomPos (), Quaternion.identity);
	//	// Rigidbody rb=go.GetComponent<Rigidbody>();
	//	// ParabolaEffect.current.LaunchBall(rb);
		
	//}

	void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<DestroyByTime>().health -= damage;
            Debug.Log(other.GetComponent<DestroyByTime>().health);
            Destroy(gameObject);

        }
    }
}