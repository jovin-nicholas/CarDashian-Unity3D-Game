using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Car_Script : MonoBehaviour
{

    /*
    float speed = 20.0f;
    float rotationSpeed = 50.0f;
    */
    public Rigidbody rb;
    public AudioClip bruh;
    //public AudioClip hp;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        //rb.centerOfMass = new Vector3(0.0f, 1.0f, 1.0f);
        rb.useGravity = true;
        //Debug.Log(Input.mousePosition);

        //Debug.Log(rb.position.y);
        /*
        Debug.Log("X" + rb.rotation.x);
        Debug.Log("Z" + rb.rotation.z);

        //rb.centerOfMass = new Vector3(0, 0, 0);

        if (rb.position.y > 10)
        {
            rb.position = new Vector3(0,0.4f,0);
        }
        */

        if (rb.position.y < 0.0f)
        {
            source.PlayOneShot(bruh,0.6F);
            //rb.rotation = new Quaternion(90f,90f,180f,90f);
            StartCoroutine(Reset());
        }

        /*
        if (rb.position.y > 5)
            source.PlayOneShot(hp, 0.2F);
        */
      

        /*
        if(rb.rotation.x < -0.2f || rb.rotation.z < -0.2f)
        {
            rb.position = new Vector3(rb.position.x, 0.4f, rb.position.z);

        }
        */

        /*
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        */
    }
    

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.2f);

        rb.position = new Vector3(10f, 0.9f, 10f);
        rb.velocity = new Vector3(0, 0, 0);
        
    }
}


