using UnityEngine;

public class RayExample : MonoBehaviour
{
    public Rigidbody _basketBall;

    public Transform _origin;
    public LayerMask layer;
    
   
    public float flightTime = 1f;
    

    public Transform target;
    public Vector3 targetDeviation;

    Vector3 targetPosition;

    

    float ballSpawnInterval = 3.0f;
    float time;

    // Start is called before the first frame update
    void Start()
    {

        time = Time.time + ballSpawnInterval;
    }

    private void Update()
    {
        if (Time.time > time)
        {
            time = Time.time + ballSpawnInterval;

            LaunchBasketBall();
        }
    }

    void LaunchBasketBall()
    {   
        targetPosition = target.position + GetDeviation(-2f,2f);    
        Vector3 vo = CalculateVelocty(targetPosition, _origin.position, flightTime);

      

        Rigidbody obj = Instantiate(_basketBall, _origin.position, Quaternion.identity);
        obj.velocity = vo;
        
    }

    //Vector3 getRandomPos()
    //{
    //	float _x = Random.Range (-2, 3);
    //	float _y = Random.Range (2, 8);
    //	float _z = -15f;
    //	Vector3 newPos = new Vector3 (_x, _y, _z);
    //	return newPos;
    //}
    Vector3 GetDeviation(float min, float max)// Fro Max Left and Right
    {
        float x = Random.Range(min, max);
        return new Vector3(x, targetDeviation.y, targetDeviation.z);
    }


    Vector3 CalculateVelocty(Vector3 target, Vector3 origin, float time)
    {
        Vector3 distance = target - origin;
        Vector3 distanceXz = distance;
        distanceXz.y = 0f;

        float sY = distance.y;
        float sXz = distanceXz.magnitude;

        float Vxz = sXz / time;
        float Vy = (sY / time) + (0.5f * Mathf.Abs(Physics.gravity.y) * time);

        Vector3 result = distanceXz.normalized;
        result *= Vxz;
        result.y = Vy;

        return result;
    }

}