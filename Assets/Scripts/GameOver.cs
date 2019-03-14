using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text score;
    public Text multiplier;
    public Text level;
    public Text FinalScore;
    public Slider rank;
    float ScoreMultiplier;
    float RankMultiplier;
    float rem;
    int sc, count , S;


    // Start is called before the first frame update
    void Start()
    {
        //FinalScore.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        sc = triggerCheck.score;
        count = triggerCheck.count;

        if (CountDownTimer.gameover)
        {
            Score();
            LevelUp();

            CountDownTimer.gameover = false;
        }
      
    }

    void Score()
    {
        score.text = "" + sc;
        multiplier.text = "" + count;

        Health.S = triggerCheck.count * triggerCheck.score;
        //yield return new WaitForSeconds(2);
        S = S + Health.S;
        FinalScore.text = "" + Health.S;

        //Health.S = 0;
       
        triggerCheck.score = 0;
        triggerCheck.count = 1;
        AccCar.damage = 0;
    }

    void LevelUp()
    {
        level.text = "" + Health.R;

        RankMultiplier = 2f * Health.R;
        ScoreMultiplier = S / RankMultiplier;

        rank.value += ScoreMultiplier;

        if (ScoreMultiplier > rank.maxValue)
        {
            rem = ScoreMultiplier - rank.maxValue;
            //rank.value = rem;
            rank.value = Mathf.MoveTowards(rank.value,rem,1f);
            Health.R++;
            
        }

        level.text = "" + Health.R;
    }
}
