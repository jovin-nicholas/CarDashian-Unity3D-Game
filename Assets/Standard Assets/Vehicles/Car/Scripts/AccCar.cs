using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AccCar : MonoBehaviour, IPointerDownHandler , IPointerUpHandler
{
    public static float CarSpeed = 0;
    bool isPointerDown = false;
    public Toggle d;
    public Toggle n;
    public Toggle r;
    public Slider aslider;
    public GameObject ReverseCam;
    public static float damage = 0;

    public virtual void OnPointerUp(PointerEventData p)
    {
        isPointerDown = false;
        aslider.value = Mathf.MoveTowards(aslider.value, -50.0f, 0.035f * aslider.value);
    }


    public virtual void OnPointerDown(PointerEventData p)
    {
        isPointerDown = true;
    }

    public float AccelerateCar()
    {
        if (d.isOn)
        {
            ReverseCam.SetActive(false);
            if (isPointerDown)
            {
                CarSpeed = CarSpeed + 500f * aslider.value;
            }

            else
            {
                CarSpeed = 0;

            }
        }

        else if (r.isOn)
        {
            ReverseCam.SetActive(true);

            if (isPointerDown)
            {
                CarSpeed -= 350f * aslider.value;
            }

            else
            {

                CarSpeed = 0;
                /*
                if(Input.mousePosition.x > 500f)
                    CarSpeed = Mathf.Clamp(CarSpeed + 0.1f, 0, 150);
                */
            }
        }

        else
        {
            ReverseCam.SetActive(false);
            CarSpeed = 0;
        }

        return CarSpeed;
    }

    void Update()
    {
        if (BreakCar.b)
            aslider.value = Mathf.Clamp(aslider.value - 2f, 0, 50);
            
    }
}
