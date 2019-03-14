using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakSlider : MonoBehaviour {
    public float t;
    float aspeed;
    //float temp;
    public static BreakSlider binstance; 

    void Awake () {
        binstance = this;
    }


    public void Slider_Changed(float NewValue)
    {
        aspeed = AccelerometerInput.instance.speed;

            t = NewValue;

        //temp = Mathf.Clamp(aspeed - NewValue, 0, 22);
    

}

}
