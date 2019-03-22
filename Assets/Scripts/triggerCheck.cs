using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class triggerCheck : MonoBehaviour
{
    public GameObject brick;
    GameObject brickclone;
    Rigidbody car;
    public static int score;
    public static bool triggered;
    public static int count=1;
    public static int wall=0;
    public static float time=0;
    float s, r;
    //float speed, power;

    /*
    GameObject[] bclone1;
    GameObject[] bclone2;
    GameObject[] bclone3;
    */



    void Awake()
    {
        car = gameObject.GetComponent<Rigidbody>();

        triggered = false;

        /*bclone1 = GameObject.FindGameObjectsWithTag("wall1");
        bclone2 = GameObject.FindGameObjectsWithTag("wall2");
        bclone3 = GameObject.FindGameObjectsWithTag("wall3");
        */


    }

    
    void OnCollisionEnter(Collision col)
    {
    //if (!triggered)
    //{
        if (col.gameObject.name == "Car")
        {
            Destroy(brick, 2f);

        //brick.AddExplosionForce(car.velocity.z,transform.position,5);


        /*
        foreach (GameObject target in bclone)
        {
            //for (int i=0;i<len;i++) 
            GameObject.Destroy(target, 6);
            triggered = true;

        }
        */
        /*
            if (GameObject.FindGameObjectWithTag("wall1"))
                DestroyWall(bclone1);

            else if (GameObject.FindGameObjectWithTag("wall2"))
                DestroyWall(bclone2);

            else if (GameObject.FindGameObjectWithTag("wall3"))
                DestroyWall(bclone3);

            */


            Score();

           
            //StartCoroutine(CreateWall());
            
        }
    //}
    }

   
    void Score()
    {

        if (car.velocity.x >= 0)
            r = car.velocity.x;

        else
            r = -car.velocity.x;


        if (car.velocity.z >= 0)
            s = car.velocity.z;
        else
            s = -car.velocity.z;

        
        AccCar.damage = AccCar.damage + 0.02f * r + 0.05f * s ;
        if (AccCar.damage >= 0)
            score = (int)AccCar.damage;
        
    }

    /*
    void DestroyWall(GameObject[] bclone)
    {
        foreach (GameObject target in bclone)
        {
            //for (int i=0;i<len;i++) 
            GameObject.Destroy(target,4);

        }

        if(bclone != null)
        {
            foreach(GameObject target in bclone)
        {
                //for (int i=0;i<len;i++) 
                GameObject.Destroy(target,2);
        
            }
        }

        triggered = true;
    }
    */

    
}