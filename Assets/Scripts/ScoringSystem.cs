using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public Text scoreText;
    public static int theScore;
    public static int _health=5;

    private void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();


    }
    private void Update()
    {
        if (_health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    //void OnCollisionEnter(Collision collision )
    //{ 
    //    if(collision.gameObject.tag == "Basket")
    //   {
    //        theScore += 1;
    //   scoreText.text ="SCORE:" + theScore;
    //     Destroy(gameObject,1f);
    //   }
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        _health = _health - 1;
    //        //   Destroy(gameObject, 1f);
    //        print("Helath " + _health);
    //        print(collision.gameObject.name);aaaaaa
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Basket")
        {
            theScore += 1;
            scoreText.text = "SCORE:" + theScore;
            //dDestroy(gameObject, 1f);
        }
        if (other.gameObject.tag == "Ground")
        {
            _health = _health - 1;
            //   Destroy(gameObject, 1f);
            print("Helath " + _health);
          //  print(collision.gameObject.name);
        }
    }
}
