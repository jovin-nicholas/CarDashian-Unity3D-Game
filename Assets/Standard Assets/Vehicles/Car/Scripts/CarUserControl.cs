using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public AccCar mvCar;
        /*
        public GameObject FloatingText1;
        public GameObject FloatingText2;
        */

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            //StartCoroutine(StartingText());
        }

        void Start()
        {
            // Disable screen dimming
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        private void FixedUpdate()
        {

            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            h = Input.acceleration.x * 2f;
            v = mvCar.AccelerateCar();
            m_Car.Move(h, v, v, 0f);
#endif
        }
        /*
        IEnumerator StartingText()
        {
            FloatingText1 = Instantiate(FloatingText1, new Vector3(transform.position.x + 2, transform.position.y + 15.5F, transform.position.z + 9F), transform.rotation);
            Destroy(FloatingText1, 2F);
            yield return new WaitForSeconds(2f);
            FloatingText2 = Instantiate(FloatingText2, new Vector3(transform.position.x + 2, transform.position.y + 15.5F, transform.position.z + 7.5F), transform.rotation);
            Destroy(FloatingText2, 2F);
        }
        */
    }
}
