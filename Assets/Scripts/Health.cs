

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider health;
    float decrement;
    public Toggle r;
    public Text text;
    float score;
    bool collide;
    public static int R = 1;
    public static int S = 0;

    void Start()
    {
        decrement = 1 / 60f;
        collide = true;
    }

    void Update()
    {

        score = triggerCheck.score;
        text.text = " " + score;
        if (r.isOn)
        {
            health.value = Mathf.MoveTowards(health.value, -150.0f, 2 * decrement);

        }

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

        //StartCoroutine(WallCollide());
        //WallCollide();
    }

}
