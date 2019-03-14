using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerometerInput : MonoBehaviour {
    /***** https://docs.unity3d.com/ScriptReference/Input-acceleration.html ****/


    // Move object using accelerometer

    float bspeed;
    public float speed;
    //GameObject a;
    public GameObject ReverseCam;
    public Slider slider;
    public Rigidbody rb;
    public Toggle d;
    public Toggle n;
    public Toggle r;
    public static AccelerometerInput instance;

    void Start()
    {
        instance = this;
 
    }

    void FixedUpdate()
    {


        //Debug.Log("Acc" + slider.value);
        /*
        Vector3 dir = Vector3.zero;

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);
    */


        speed = slider.value;
        bspeed = BreakSlider.binstance.t;

        /********** https://www.youtube.com/watch?v=XZWNXsjIvrE&feature=youtu.be ************/
        if(Input.mousePosition.x > 1000)
           StartCoroutine(ASlider_Changed());

        if (Input.mousePosition.x < 500)
            StartCoroutine(BSlider_Changed());

        if (slider.value >= 20f)
        {
            StartCoroutine(FullAcc());
        }

    }


    IEnumerator FullAcc()
    {
        yield return new WaitForSeconds(0.1f);
        speed = Mathf.Clamp(slider.value+10f, 0, 100);
        //Debug.Log(speed);
        rb.velocity = new Vector3(-Input.acceleration.x * 0.01f * speed, 0,  slider.value += 0.2f);

    }



    IEnumerator ASlider_Changed()
    {
        yield return new WaitForSeconds(0.01f);
        speed = slider.value;
        //if (Input.mousePosition.x > 500f)

        if (d.isOn)
        {
            ReverseCam.SetActive(false);
           
                if (Input.GetMouseButton(0))
                {
                    transform.Rotate(0, Input.acceleration.x * 0.4f * slider.value, 0);
                    //Debug.Log("Up" + rb.rotation.y);
                    rb.velocity = new Vector3(0, 0, 0.6f * slider.value);
                    transform.Translate(-Input.acceleration.x * 0.01f * slider.value, 0, -0.02f * slider.value);
                    rb.AddForce(rb.velocity * 5f, ForceMode.Acceleration);
                }  


        }



        else if (r.isOn)
        {
            /*
            if (rb.velocity.y > 0)
            {
                if (Input.GetMouseButton(0))
                {
                    transform.Rotate(0, Input.acceleration.x * 0.4f * slider.value, 0);
                    rb.velocity = new Vector3(0, 0, -1.5f * slider.value);

                }
            }

            else
            {
                if (Input.GetMouseButton(0))
                {
                    rb.velocity = new Vector3(0, 0, -1.5f * slider.value);
                    transform.Rotate(0, Input.acceleration.x * 0.4f * slider.value, 0);

                }
            }*/
            //rb.centerOfMass=new Vector3(0, 1, 1);

            if (Input.GetMouseButton(0))
            {
                transform.Rotate(0, Input.acceleration.x * 0.4f * slider.value, 0);
                //Debug.Log("Up" + rb.rotation.y);
                rb.velocity = new Vector3(0, 0, -0.6f * slider.value);
                transform.Translate(-Input.acceleration.x * 0.01f * slider.value, 0, 0.02f * slider.value);
            }
            ReverseCam.SetActive(true);
        }

        else
        {
            if (Input.GetMouseButton(0))
                transform.Translate(0, 0, 0);
            ReverseCam.SetActive(false);

        }

    }


    IEnumerator BSlider_Changed()
    {
        yield return new WaitForSeconds(0.01f);
        float t = Mathf.Clamp(speed-bspeed, 0, 5);


        if (d.isOn)
        {
          
            
                if (Input.GetMouseButton(0))
                {
                    //transform.Translate(Input.acceleration.x * 0.01f * t, 0, 0.02f * t);
                    rb.velocity = new Vector3(0, 0, -0.6f * t);
                    transform.Translate(-Input.acceleration.x * 0.01f * t, 0, 0.02f * t);
                }


            else
                transform.Translate(0, 0, 0);
        }

        else if (r.isOn)
        {
            
            
            if (Input.GetMouseButton(0))
            {
                transform.Translate(Input.acceleration.x * 0.1f * t, 0, 0.03f * t);
            }
       

            else
                if(Input.GetMouseButton(0))
                transform.Translate(0, 0, 0);
        }


        else
            transform.Translate(0, 0, 0);

    }




}
