using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text rank;

    public void PlayGame()
    {
        SceneManager.LoadScene(2);

    }

    public void TrackSelect()
    {
        SceneManager.LoadScene(1);

    }

    public void Main_Menu()
    {
        SceneManager.LoadScene(0);

    }

    public void Track01()
    {
        SceneManager.LoadScene(2);

    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    void Update()
    {
        rank.text = "" + Health.R;
    }

}
