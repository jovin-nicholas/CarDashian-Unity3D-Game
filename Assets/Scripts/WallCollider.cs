using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollider : MonoBehaviour
{

    //public GameObject lock1;
    //public GameObject lock2;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;

    //public static float rem = 0;
    public static bool over;
    bool m, n, o;
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "wall1" )
        {
            light1.SetActive(false);
            mark1.SetActive(false);
            //triggerCheck.wall++;
            SSTools.ShowMessage("+" + triggerCheck.score, SSTools.Position.top, SSTools.Time.threeSecond);
            m = true;
            //Destroy(gameObject,3f);
            //gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "wall2" )
        {
            light2.SetActive(false);
            mark2.SetActive(false);
            //triggerCheck.wall++;
            SSTools.ShowMessage("+" + triggerCheck.score, SSTools.Position.top, SSTools.Time.threeSecond);
            n = true;
            //Destroy(gameObject,3f);
            //gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "wall3" )
        {
            light3.SetActive(false);
            mark3.SetActive(false);
            //triggerCheck.wall++;
            SSTools.ShowMessage("+" + triggerCheck.score, SSTools.Position.top, SSTools.Time.threeSecond);
            o = true;
            //Destroy(gameObject,3f);
            //gameObject.SetActive(false);
        }

        //Debug.Log(triggerCheck.wall);

    }

    void Update()
    {
        Condition(m, n);
        Condition(n, o);
        Condition(m, o);

        if (triggerCheck.wall > 0)
        {
            StartCoroutine(SceneChange());
        }
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(3f);
        SSTools.ShowMessage("Great!", SSTools.Position.top, SSTools.Time.oneSecond);
        triggerCheck.wall = 0;
        CountDownTimer.gameover = true;
        //rem += 1*Time.deltaTime;
        over = true;
        //SceneManager.LoadScene(3);

    }

    void Condition(bool a,bool b)
    {
        if (a && b)
            triggerCheck.wall++;
    }

}
