using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AccSlider : MonoBehaviour
{
    public Rigidbody rb;
    /*
    public GameObject ReverseCam;
    //public Button d ;
    //public Button n ;
    //public int gear;
    public Transform target;
    public Toggle d;
    public Toggle n;
    public Toggle r;
    */
    public Slider slider ;
    public float speed;
    public static AccSlider instance;
    // private GameObject cameraContainer;
    //private Quaternion rot;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        instance = this;

    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        speed = slider.value;

        //speed = Mathf.Clamp(speed + accelerate, 0.1f ,2.5f);
    }


    /*

    public void Slider_Changed()
    {

        speed = slider.value;
        //if (Input.mousePosition.x > 500f)

        if (d.isOn)
        {
            if (rb.rotation.y <= 0.2f)
            {
                if (Input.GetMouseButton(0))
                    rb.velocity = new Vector3(0, 0, -2f * slider.value);
            }
            
            else if (rb.velocity.y >= -0.7f && rb.velocity.y <= 0)
            {
                if (Input.GetMouseButton(0))
                    rb.velocity = new Vector3(0, 0, -2.5f * slider.value);
                Debug.Log("Loop 2");
            }
            
            else
            {
                if (Input.GetMouseButton(0))
                    rb.velocity = new Vector3(0, 0, 2.5f * slider.value);
                ReverseCam.SetActive(false);

            }
        }


        else if (r.isOn)
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, -2.5f * slider.value);
            ReverseCam.SetActive(false);
        }

        else
        {
            if (Input.GetMouseButton(0))
                transform.Translate(0, 0, 0);
            ReverseCam.SetActive(false);

        }

    }
    */
}
