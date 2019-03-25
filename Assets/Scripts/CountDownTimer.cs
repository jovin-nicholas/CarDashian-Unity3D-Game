using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 90f;
    public static bool gameover;
    public bool start;
    public bool created;
    public Slider slider;
    public GameObject CurveArrow;
    public GameObject FloatingText1;
    public GameObject FloatingText2;
    public Rigidbody car;
    int rem;
    //SoundManager soundManager;

    public Transform parentCanvas;

    [SerializeField] Text countdownText;

    void Awake()
    {
        //car = gameObject.GetComponent<Rigidbody>();
        //StartCoroutine(StartingText());
    }

    void Start ()
    {
        currentTime = startingTime;
        CurveArrow = Instantiate(CurveArrow, new Vector3(car.position.x + 15, car.position.y + 10, car.position.z - 24), new Quaternion(200, 120, 0, 0));
       // soundManager = car.gameObject.GetComponent<SoundManager>();
		
	}
	
	
	void Update ()
    {
        if (slider.value > 0)
            start = true;

        if (start)
        {


            if (PauseMenu.GameIsPaused)
                currentTime = currentTime + 0;

            else
            {
                currentTime -= 1 * Time.deltaTime;
                countdownText.text = currentTime.ToString("0");

                if (currentTime <= 10)
                    countdownText.color = Color.red;

                if (currentTime <= 0)
                {
                    currentTime = 0;
                    SceneManager.LoadScene(3);
                    gameover = true;
                    
                }

            }
        }

        else
            currentTime = currentTime + 0;
        
        if (WallCollider.over)
        {
            rem = (int)currentTime;
            Debug.Log(rem);
            triggerCheck.time = rem;
            //WallCollider.over = false;
            triggerCheck.wall = 0;
            SceneManager.LoadScene(3);
        }
          
        StartCoroutine(StartingText());

    }



    IEnumerator StartingText()
    {
        if (PauseMenu.GameIsPaused)
        {
            FloatingText1.SetActive(false);
            created = false;
        }

        else
        {
            if (!start)
            {
                if (!created)
                {
                    FloatingText1.SetActive(true);
                    //FloatingText1 = Instantiate(FloatingText1, new Vector3(410, 320, 0), Quaternion.identity, parentCanvas);

                }
                created = true;
            }


            else
            {

                FloatingText1.SetActive(false);
                //Destroy(FloatingText1);
                Destroy(CurveArrow);
                //yield return new WaitForSeconds(2f);
                if (created)
                {
                    FloatingText2.SetActive(true);
                    //FloatingText2 = Instantiate(FloatingText2, new Vector3(415, 430, 0), Quaternion.identity, parentCanvas);
                    //soundManager.UpdateAudioCollection();
                }
            }
        }
        yield return null;
    }
    
}
