using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrid : MonoBehaviour
{

    //public GameObject Wall;
    public GameObject brick;
    public GameObject brickclone;
    public Rigidbody car;
    bool r;
    float o;
    GameObject[] bclone;

    void Awake()
    {
        r = false;
        CreateWall();
        
    }


    void Update()
    {
        /*
        //r = triggerCheck.triggered;
        r = triggerCheck.instance.triggered;
        //r = brick.GetComponent<triggerCheck>().triggered;

        if (r)
        {
            Debug.Log("Create");
            CreateWall();
        }
        */
        //Debug.Log("Height"+o);
    }


    void CreateWall()
    {
        //float m = Random.Range(car.position.x + 20, car.position.x + 40);
        //float n = Random.Range(car.position.z + 10, car.position.z + 50);
        o = Terrain.activeTerrain.SampleHeight(transform.position);
        for (float y = 0; y < 14; y = y + 3f)
        {
            for (float x = 0; x < 48; x = x + 3f)
            {

                //Instantiate(brick, new Vector3(m+x, 0.5f+y, n), Quaternion.identity);

                brickclone = Instantiate(brick, new Vector3(transform.position.x + x, 1.5f + o + y, transform.position.z), Quaternion.identity);
            }
        }

        //brick.GetComponent<triggerCheck>().triggered = false;
        //triggerCheck.triggered = false;
        r = false;
    }
    /*
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Car")
        {
            if (GameObject.FindGameObjectWithTag("wall1"))
            {
                bclone = GameObject.FindGameObjectsWithTag("wall1");
                foreach (GameObject target in bclone)
                    Destroy(target);                
            }

            else if(GameObject.FindGameObjectWithTag("wall2"))
            {
                bclone = GameObject.FindGameObjectsWithTag("wall2");
                foreach (GameObject target in bclone)
                    Destroy(target);
            }

            else if (GameObject.FindGameObjectWithTag("wall3"))
            {
                bclone = GameObject.FindGameObjectsWithTag("wall3");
                foreach (GameObject target in bclone)
                    Destroy(target);
            }


        }
    }
    */
}
