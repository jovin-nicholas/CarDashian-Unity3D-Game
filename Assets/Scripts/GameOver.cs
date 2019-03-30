using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text score;
    public Text multiplier;
    public Text remTime;
    public Text level;
    public Text FinalScore;
    public Text BestScore;
    public Slider rank;
    int R;
    float ScoreMultiplier;
    float RankMultiplier;
    float v = 0;
    int rem, sc, count, S, bestScore;


    // Start is called before the first frame update
    void Start()
    {
        //FinalScore.text = "";
        R = PlayerPrefs.GetInt("rank", 1);
        bestScore = PlayerPrefs.GetInt("best", 0);

    }

    // Update is called once per frame
    void Update()
    {
        sc = triggerCheck.score;
        count = triggerCheck.count;
        rem = triggerCheck.time;
        
        //Debug.Log(triggerCheck.time);


        if (CountDownTimer.gameover || WallCollider.over)
        {

            //WallCollider.rem = 0;
            Score();
            StartCoroutine(LevelUp());
            CountDownTimer.gameover = false;
            WallCollider.over = false;
        }

    }

    void Score()
    {
        score.text = "" + sc;
        multiplier.text = "" + count;
        remTime.text = "" + rem;

        S = triggerCheck.count * triggerCheck.score + triggerCheck.time;
        //yield return new WaitForSeconds(2);
        //Health.S = S + Health.S;
        FinalScore.text = "" + S;
        remTime.text = "" + rem;

        if (bestScore < S)
        {
            bestScore = S;
            PlayerPrefs.SetInt("best", S);

        }
        /*
        else
            PlayerPrefs.SetInt("best", bestScore);
        */
        //bestScore = PlayerPrefs.GetInt("best", 0);
        BestScore.text = "" + bestScore;

        //S = 0;
        triggerCheck.score = 0;
        triggerCheck.count = 1;
        triggerCheck.time = 0;
        triggerCheck.wall = 0;
        AccCar.damage = 0;
    }

    IEnumerator LevelUp()
    {
        yield return null;
        //level.text = "" + Health.R;
     
        RankMultiplier = 1.2f * R;
        ScoreMultiplier = S / RankMultiplier;
        float currentValue = PlayerPrefs.GetFloat("rslider", 0);
        float finalValue = currentValue + ScoreMultiplier;
        //Health.S += ScoreMultiplier; 

        if (finalValue < rank.maxValue)
            //rank.value = finalValue + ScoreMultiplier;
            v = currentValue;
            rank.value = Mathf.MoveTowards(currentValue,finalValue,v*0.015f);
            /*
            while (v <= finalValue)
            {
                v = Mathf.Clamp01(v*Time.deltaTime);
                rank.value = v;
            }
            */
            

        while (finalValue >= rank.maxValue)
        {
            finalValue -= rank.maxValue;
            R++;
            RankMultiplier = 1.2f * R; 
            ScoreMultiplier = finalValue / RankMultiplier;

            rank.value = finalValue;
            /*
            while (v <= finalValue)
            {
                
                //v = Mathf.Clamp01(finalValue/.9f);
                v = Mathf.MoveTowards(0,finalValue,Time.deltaTime * 2.02f);
                rank.value = v;
            }
            */
            //Health.SliderValue = 0;
        }

        PlayerPrefs.SetFloat("rslider", finalValue);
        PlayerPrefs.SetInt("rank", R);
        level.text = "" + R;
    }
}
