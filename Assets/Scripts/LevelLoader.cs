using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider slider;
    public Text ProgressText;
    public Text HintText;

    string hint1 = "Hit the walls to increase the score. Greater the velocity, greater the score";
    string hint2 = "Collect the sphere power ups to increase the score multiplier";
    string hint3 = "Goal is to reach the target wall.";

    string text1 = "YEET";
    string text2 = "NO U";
    string text3 = "Sub2Pewds";

    int r;

    public void LoadLevel(int scene)
    {

        StartCoroutine(LoadAsynchronously(scene));
    }

    IEnumerator LoadAsynchronously(int scene)
    {

        AsyncOperation operation;
        operation = SceneManager.LoadSceneAsync(scene);
        loadingScreen.SetActive(true);
        //yield return new WaitForSeconds(2f);

        while (!operation.isDone)
        {
            r = Random.Range(1, 5);
            StartCoroutine(Hints(scene));
            //yield return new WaitForSeconds(0.02f);
            yield return new WaitForSeconds(operation.progress);
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            ProgressText.text = progress * 100f + "%";

        }

    }
    
    
    IEnumerator Hints(int scene)
    {
        //yield return new WaitForSeconds(0.02f);

        r = Random.Range(1, 5);

        if (scene == 2)
        {
            if (r == 1)
                HintText.text = "" + hint1;

            else if (r == 2)
                HintText.text = "" + hint2;

            else
                HintText.text = "" + hint3;
        }

        if(scene == 1)
        {
            if (r == 1)
                HintText.text = "\n\t\t\t" + text1;

            else if (r == 2)
                HintText.text = "\n\t\t" + text2;

            else
                HintText.text = "\n\t\t" + text3;
        }

        yield return new WaitForSeconds(0.5f);
    }
    
    
}
