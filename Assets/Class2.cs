using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Class2 : MonoBehaviour
    {
        // Start is called before the first frame update
     public Class1 SelectColor(bool isBlue)
        {
          //  public Triangle GetTriangle(bool isBlue)
            {
                Class1 resultTriangle;

                if (isBlue)
                {
                    resultTriangle = new Class1 { color = "Blue" };
                }
                else
                {
                    resultTriangle = new Class1 { color = "Red" };
                }

                return resultTriangle;
            }
        }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Class1 a=SelectColor(true);
            Debug.Log("a " + a.color);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Class1 a = SelectColor( false);
            Debug.Log("a " + a.color);
        }
    }
}
