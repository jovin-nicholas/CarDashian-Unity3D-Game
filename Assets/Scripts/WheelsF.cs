using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelsF : MonoBehaviour
{
    public float aspeed;
    public Toggle r;
    float rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aspeed = AccelerometerInput.instance.speed;
        rot = Input.acceleration.x * 4f;
        
        if(r.isOn)
            transform.Rotate(-1.2f * aspeed, 0,0);

        else
            transform.Rotate(1.2f * aspeed, 0, 0);
    }
}
