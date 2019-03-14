using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockTarget : MonoBehaviour
{

    public GameObject lock1;
    public GameObject lock2;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "wall1" || col.gameObject.tag == "wall2")
        {
            triggerCheck.wall++;
            Destroy(gameObject);
        }
        Debug.Log(triggerCheck.wall);
    }
    // Update is called once per frame
    void Update()
    {
        if(triggerCheck.wall > 2)
        {
            lock1.SetActive(false);
            lock2.SetActive(false);

            triggerCheck.wall = 0;
        }
    }
}
