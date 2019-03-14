using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    /*
    public GameObject bomb;
    public Slider power;
    public Rigidbody car;
    bool triggered;
    float m, n, o;
    public static float health;
    public Text text;
    */
    //public GameObject pickupEffect;
    /*
    void Awake()
    {
        
        power = GameObject.Find("HealthSlider").GetComponent<Slider>();
        car = GameObject.Find("Car").GetComponent<Rigidbody>();
        text = GameObject.Find("Multiplier").GetComponent<Text>();

    }
    */

    void Start()
    {
        //InvokeRepeating("Passed", 8.0f, 8f);
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Car")
        {
            Pickup();

        }
    }
    */

        /*
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Car")
        {
            power.value += 10;

            Destroy(bomb);
            Instantiate(bomb, new Vector3(m, 3f + o, n), Quaternion.identity);
            //Instantiate(pickupEffect, new Vector3(m, o + 0.5f, n), Quaternion.identity);

            //Instantiate(pickupEffect, transform.position, transform.rotation);
            //player.transform.localScale *= multiplier;


            triggerCheck.count++;
            text.text = "" + triggerCheck.count;

            triggered = false;
        }
    }
    */        
    
    /*
    void Pickup()
    {
       
        if (triggered)
        {
            power.value += 10;
            
            Instantiate(bomb, new Vector3(m, 3f + o, n), Quaternion.identity);
            Destroy(bomb);
            //Instantiate(pickupEffect, new Vector3(m, o + 0.5f, n), Quaternion.identity);

            //Instantiate(pickupEffect, transform.position, transform.rotation);
            //player.transform.localScale *= multiplier;


            triggerCheck.count++;
            text.text = "" + triggerCheck.count;

            triggered = false;

        }
      
     */ 

        /*
        if (!triggered)
            //Destroy(GameObject.FindGameObjectWithTag("ExEffect"),1f);
            Destroy(GameObject.FindGameObjectWithTag("SEffect"), 4f);
            
         */

    

    /*
    void OnBecameInvisible()
    {
        Debug.Log("Passed");
        passed = true;
        Destroy(bomb);
        Pickup();
    }
    */

    void Update()
    {
        /*
        m = Random.Range(car.position.x + 100, car.position.x + 200);
        n = Random.Range(car.position.z + 0, car.position.z + 5);
        o = Terrain.activeTerrain.SampleHeight(new Vector3(m,transform.position.y,n));

        //Debug.Log(car.GetRelativePointVelocity(transform.position));
        health = power.value;
        */

    }

    void Passed()
    {
        /*
        Instantiate(bomb, new Vector3(m, 3f + o, n), Quaternion.identity);
        Destroy(bomb);
        */
        //yield return new WaitForSeconds(8);
        /*
        if (!passed)
        {
            Destroy(bomb);
            Instantiate(bomb, new Vector3(m, 3f + o, n), Quaternion.identity);

            passed = true;
        }

        //yield return new WaitForSeconds(8);
        passed = false;
        */
    }
}
    