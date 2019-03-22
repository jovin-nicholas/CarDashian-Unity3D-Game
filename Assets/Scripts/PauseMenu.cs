using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject ASlider;
    public GameObject breakbutton;
    public GameObject car;
    Vector3 saveVelocity;
    Vector3 saveAngularVelocity;

    void Update()
    {
        if (!GameIsPaused)
            Resume();

        if(Input.GetKeyDown(KeyCode.Escape))
        {

            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        ASlider.SetActive(true);
        breakbutton.SetActive(true);

        //car.GetComponent<Rigidbody>().velocity = Vector3.zero;
        /*
        car.GetComponent<Rigidbody>().velocity = saveVelocity;
        car.GetComponent<Rigidbody>().angularVelocity = saveAngularVelocity;
        */
    }

    void Pause ()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        ASlider.SetActive(false);
        breakbutton.SetActive(false);

        //car.GetComponent<Rigidbody>().Sleep();

        /*
        saveVelocity = car.GetComponent<Rigidbody>().velocity;
        saveAngularVelocity = car.GetComponent<Rigidbody>().angularVelocity;
        */


    }

    public void LoadMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Menu");
        //Time.timeScale = 1;
        triggerCheck.score = 0;
        triggerCheck.count = 1;
        AccCar.damage = 0;
        GameIsPaused = false; 
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
    
        
  
}
