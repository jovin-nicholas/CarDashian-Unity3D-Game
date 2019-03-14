using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BreakCar : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{
    public Rigidbody Car;
    public static bool b = false;

    public virtual void OnPointerDown(PointerEventData p)
    {
        b = true;
        //StartCoroutine(Break());
    }


    public virtual void OnPointerUp(PointerEventData p)
    {
        b = false; ;
        //StartCoroutine(Break());
    }


    /* 
   public void OnClick()
   {
       StartCoroutine(Break());
   }
    */
    /*
   IEnumerator Break()
   {
       yield return new WaitForSeconds(0.01f);

       Car.GetComponent<Rigidbody>().velocity = Vector3.zero;
       AccCar.CarSpeed = Mathf.Clamp(AccCar.CarSpeed - 15f*Time.deltaTime, 0, 150);

       yield return new WaitForSeconds(4f);
       b = false;

   }
   */
    void Update()
    {
        if(b)
            Car.GetComponent<Rigidbody>().velocity = Vector3.zero;
            AccCar.CarSpeed = Mathf.Clamp(AccCar.CarSpeed - 15f , 0, 150);


        //Debug.Log("Velocity" + Car.velocity);

    }

}
