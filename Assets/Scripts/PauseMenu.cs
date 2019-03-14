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

    void Update()
    {
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

    }

   void Pause ()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = true;
        ASlider.SetActive(false);
        breakbutton.SetActive(false);

    }

    public void LoadMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Menu");

    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
    
        
  
}
