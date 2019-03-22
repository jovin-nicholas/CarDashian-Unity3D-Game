using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marker : MonoBehaviour
{
    public GameObject bomb;
    public Slider power;
    public Rigidbody car;
    public static float health;
    public Text text;

    public GameObject TheMarker;
    public GameObject MARK01;
    public GameObject MARK02;
    public GameObject MARK03;
    public GameObject MARK04;
    public GameObject MARK05;
    public GameObject MARK06;
    public GameObject MARK07;
    public GameObject MARK08;
    public GameObject MARK09;
    public GameObject MARK10;
    public GameObject MARK11;
    public GameObject MARK12;
    public GameObject MARK13;
    public GameObject MARK14;
    public GameObject MARK15;
    public GameObject MARK16;
    public GameObject MARK17;
    public GameObject MARK18;
    public GameObject MARK19;
    public GameObject MARK20;
    public GameObject MARK21;
    public GameObject MARK22;
    public GameObject MARK23;
    public GameObject MARK24;
    public int MarkTracker;

    void Start()
    {
        InvokeRepeating("RespawnPower", 10.0f, 8f);

    }

    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = MARK01.transform.position;
        }

        if (MarkTracker == 1)
        {
            TheMarker.transform.position = MARK02.transform.position;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = MARK03.transform.position;
        }

        if (MarkTracker == 3)
        {
            TheMarker.transform.position = MARK04.transform.position;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = MARK05.transform.position;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = MARK06.transform.position;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = MARK07.transform.position;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = MARK08.transform.position;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = MARK09.transform.position;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = MARK10.transform.position;

        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = MARK11.transform.position;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = MARK12.transform.position;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = MARK13.transform.position;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = MARK14.transform.position;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = MARK15.transform.position;
        }
        if (MarkTracker == 15)
        {
            TheMarker.transform.position = MARK16.transform.position;
        }
        if (MarkTracker == 16)
        {
            TheMarker.transform.position = MARK17.transform.position;
        }
        if (MarkTracker == 17)
        {
            TheMarker.transform.position = MARK18.transform.position;
        }
        if (MarkTracker == 18)
        {
            TheMarker.transform.position = MARK19.transform.position;
        }
        if (MarkTracker == 19)
        {
            TheMarker.transform.position = MARK20.transform.position;
        }
        if (MarkTracker == 20)
        {
            TheMarker.transform.position = MARK21.transform.position;
        }
        if (MarkTracker == 21)
        {
            TheMarker.transform.position = MARK22.transform.position;
        }
        if (MarkTracker == 22)
        {
            TheMarker.transform.position = MARK23.transform.position;
        }
        if (MarkTracker == 23)
        {
            TheMarker.transform.position = MARK24.transform.position;
        }

    }

    void RespawnPower()
    {
            
            //this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 24)
            {
                MarkTracker = 0;
            }

            // this.GetComponent<BoxCollider>().enabled = true;
            
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Car")
        {
            MarkTracker++;
            //Destroy(bomb);

            power.value += 10;
            
            triggerCheck.count++;
            text.text = "" + triggerCheck.count;

            SSTools.ShowMessage(" x" + triggerCheck.count, SSTools.Position.top, SSTools.Time.twoSecond);


        }
    }


}
