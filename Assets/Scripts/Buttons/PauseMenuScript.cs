using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{

   public GameObject PauseMenu;
   public GameObject PauseButton;
   
   public void PauseMenuFunc()
   {
       if(Time.timeScale == 1f)
       {
           Time.timeScale = 0f;
       }
       PauseMenu.SetActive(true);
       PauseButton.SetActive(false);
   }

   public void ResumeMenuFunc()
   {
       if(Time.timeScale == 0f)
       {
           Time.timeScale = 1f;
       }
       PauseMenu.SetActive(false);
       PauseButton.SetActive(true);
   }

   public void MainQuit()
    {
       Debug.Log("Quit Working");
        Application.Quit();
    }

     public void Menu()
     {
         SceneManager.LoadScene("MainMenu");
     }
}
