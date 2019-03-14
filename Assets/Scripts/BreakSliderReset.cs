using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BreakSliderReset : MonoBehaviour
{
    public Slider bslider;
    
    void LateUpdate()
    {
        //if(Input.mousePosition.x > 100f)
        //Debug.Log(Input.mousePosition.x);

        StartCoroutine(BreakReset());

    }

    IEnumerator BreakReset()
    {
        yield return new WaitForSeconds(0.01f);
        if (!Input.GetMouseButton(0))
       //if(Input.mousePosition.x < 500 || !Input.GetMouseButton(0))
            bslider.value = Mathf.MoveTowards(bslider.value, -50.0f, 0.035f * bslider.value);
    }
}
