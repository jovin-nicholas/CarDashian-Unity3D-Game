using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDown : MonoBehaviour {

    public GameObject Countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject CountDownTimer;
    public GameObject CameraView;
    public GameObject AccSlider;
    //public GameObject CarControls;

	void Start () {

        StartCoroutine((CountStart ()));
		
	}
	
	IEnumerator CountStart ()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        GetReady.Play();
        Countdown.SetActive (true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);

        GoAudio.Play();

        CountDownTimer.SetActive(true);
        //CarControls.SetActive(true);
        CameraView.SetActive(true);
        AccSlider.SetActive(true);

    }
	
}
