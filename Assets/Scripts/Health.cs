

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //public Slider health;
    //public static int R;
    //public static float S;

    public Toggle r;
    public Text text;
    public Toggle view;

    int clicked = 0;
    float decrement;
    float score;
    bool collide;

    void Start()
    {
        decrement = 1 / 60f;
        collide = true;
        //PlayerPrefs.SetInt("rank", R);
        //R = PlayerPrefs.GetInt("rank", 1);
    }

    void Update()
    {

        score = triggerCheck.score;
        text.text = " " + score;

        if (r.isOn)
        {
            //health.value = Mathf.MoveTowards(health.value, -150.0f, 2 * decrement);

        }
        /*
        else
        {
            health.value = Mathf.MoveTowards(health.value, -150.0f, decrement);
        }

        if (triggerCheck.triggered)
        {
            if (collide)
            {
                collide = false;
                health.value -= 10;
            }
        }
        */

        //StartCoroutine(WallCollide());
        //WallCollide();
    }

    public void OnClick()
    {
        
        if (view.isOn)
        {
            clicked++;
            if (clicked == 10)
            {
                triggerCheck.score += 500;
                //text.text = " " + score;
            }
        }
    }

}
