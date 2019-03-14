using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelsB : MonoBehaviour
{
    public float aspeed;
    public Toggle r;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        aspeed = AccelerometerInput.instance.speed;
        if(r.isOn)
            transform.Rotate(-1.6f * aspeed, 0, 0);
        

        else
            transform.Rotate(1.6f * aspeed, 0, 0);


    }
}
