using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReStart : MonoBehaviour
{
    // Start is called before the first frame updatepub
     public void ReStartGame()
     {
         SceneManager.LoadScene("MainScene");
        ScoringSystem._health = 5;
        ScoringSystem.theScore = 0;

    }

       public void Play()
     {
         SceneManager.LoadScene("MainScene");
         if(Time.timeScale == 0f)
       {
           Time.timeScale = 1f;
       }
     }
}
