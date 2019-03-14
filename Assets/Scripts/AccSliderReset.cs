using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AccSliderReset : MonoBehaviour {

    public Slider aslider;
    
    /*
    public PointerEventData ped;
    public void OnPointerDown(PointerEventData eventData)
    {
        //Output the name of the GameObject that is being clicked
        Debug.Log(name + "Game Object Click in Progress" + eventData);
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(name + "No longer being clicked");
        StartCoroutine(AccReset());

    }
    */
    void LateUpdate()
    {
        //if(Input.mousePosition.x < 500)
        //Debug.Log(Input.mousePosition.x);

        StartCoroutine(AccReset());
    }
    
    
    IEnumerator AccReset()
    {
        yield return new WaitForSeconds(0.01f); 

        if (!Input.GetMouseButton(0))
        //if(!Input.GetMouseButton(0) || Input.mousePosition.x >1000)
            aslider.value = Mathf.MoveTowards(aslider.value, -50.0f, 0.035f * aslider.value);
    }
    
}

