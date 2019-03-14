using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 90f;
    public static bool gameover;

    [SerializeField] Text countdownText;

	void Start ()
    {
        currentTime = startingTime;
    
		
	}
	
	
	void Update ()
    {
        if (PauseMenu.GameIsPaused)
            currentTime = currentTime + 0;

        else
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                SceneManager.LoadScene(3);
                gameover = true;

            }

        }
	}
}
