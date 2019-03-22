using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockTarget : MonoBehaviour
{
    int n, m;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;

    /*
    public GameObject lock1;
    public GameObject lock2;
    bool collide = false;
    */
      
    //public GameObject FloatingTextPrefab;


    /*
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "wall1" || col.gameObject.tag == "wall2")
        {
            triggerCheck.wall++;
            collide = true;
            Destroy(gameObject,3f);
            //gameObject.SetActive(false);
        }
        //Debug.Log(triggerCheck.wall);
        
    }

    void Update()
    {
        if(triggerCheck.wall > 50)
        {
            lock1.SetActive(false);
            lock2.SetActive(false);

            //triggerCheck.wall = 0;
        }

        if (collide)
        {
            SSTools.ShowMessage(" +" + triggerCheck.score, SSTools.Position.top, SSTools.Time.threeSecond);
            collide = false;
        }
    }
  */
    void Start()
    {
        n = Random.Range(1, 4);
        m = Random.Range(1, 4);

        while (n == m)
        {
            m = Random.Range(1, 4);
        }

        Wall(n);
        Wall(m);
    }

    void Wall(int a)
    {
        if (a == 1)
            wall1.SetActive(true);

        else if(a == 2)
            wall2.SetActive(true);

        else
            wall3.SetActive(true);
    }
}
