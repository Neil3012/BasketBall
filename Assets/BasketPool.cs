using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketPool : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _prefab;
[SerializeField]
    int maxCount=0;
    [SerializeField]
    List<GameObject> _basketballs;
    Vector3 _target;
    float timer=0f;
    Camera cam;
    public LayerMask layer;
    void InitializePool()
    {
        GameObject _parent=new GameObject();
        _parent.name="Pool_Basket";
        _parent.transform.position=Vector3.zero;
        _parent.transform.rotation=Quaternion.identity;
        for(int i=0;i<maxCount;i++)
        {
            GameObject gameObject=Instantiate(_prefab);
            gameObject.SetActive(false);
            gameObject.transform.parent=_parent.transform;
            _basketballs.Add(gameObject);
        }


    }
    void Start()
    {
        cam = Camera.main;
        _basketballs=new List<GameObject>();
        InitializePool();
    }
    RaycastHit hit;
    Ray camRay;
    // Update is called once per frame
    void Update()
    {
         camRay = cam.ScreenPointToRay(Input.mousePosition);
      
        if (Physics.Raycast(camRay, out hit, 1000, layer))
        {

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(" Name " + hit.ToString());
                _target = hit.point;
                //_basketballs[num].SetActive(true);
                //// _basketballs[num].transform.position = getRandomPos();
                //Rigidbody rigidbody = _basketballs[num].GetComponent<Rigidbody>();
                //ParabolaEffect.current.LaunchBall(rigidbody, _target);
            }

        }
        timer +=1f;
        //PopulateBall(); 
    }

    void PopulateBall(){
        //print("Fuction");
        if(timer>3f)
        {
            //print("loop");
            int num=Random.Range(0,maxCount);
            if(!_basketballs[num].gameObject.activeInHierarchy)
            {
                Ray camRay = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
               if(Physics.Raycast(camRay,out hit,1000,layer))
                {

                    if (Input.GetMouseButtonDown(0))
                    {
                        Debug.Log(" Name " + hit.ToString());
                        _target = hit.point;
                        _basketballs[num].SetActive(true);
                        // _basketballs[num].transform.position = getRandomPos();
                        Rigidbody rigidbody = _basketballs[num].GetComponent<Rigidbody>();
                        ParabolaEffect.current.LaunchBall(rigidbody, _target);
                    }
                 
                }
          
               


                
            }
            timer-=1f;
        }
    }
    Vector3 getRandomPos()
	{
		float _x = Random.Range (-2, 3);
		float _y = Random.Range (2, 8);
		float _z = -15f;
		Vector3 newPos = new Vector3 (_x, _y, _z);
		return newPos;
	}
}
