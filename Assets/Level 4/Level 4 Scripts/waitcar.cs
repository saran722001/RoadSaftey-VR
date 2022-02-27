using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class waitcar : MonoBehaviour
{
    [SerializeField]
    private GameObject Waitmsg;

    [SerializeField] private GameObject gained;
    public float time = 5;

    public Text timetext;

    public GameObject timeobject;
    // public timer timescript;


   // CrosswalkTrigger getrespawn;
    private bool can_go = false;

    private bool starttime, timeFinished;

    scorepoints scoreobj;

    private points _points;

    private GameObject car;

   // private GameObject respawnpoint;
    //  private Scoringsystem scoreboard;

    void Start()
    {
        Waitmsg.SetActive(false);
        // timescript= GameObject.FindGameObjectWithTag("timings").GetComponent<timer>();
      //  getrespawn = GameObject.FindGameObjectWithTag("sidewalk").GetComponent<CrosswalkTrigger>();
        print("set");
        scoreobj = GameObject.FindGameObjectWithTag("scoreboard").GetComponent<scorepoints>();
        _points = GameObject.FindGameObjectWithTag("point").GetComponent<points>();
        car = GameObject.FindGameObjectWithTag("car");
        // respawnpoint = GameObject.FindGameObjectWithTag("Respawn");
        //scoreboard = 
        gained.SetActive(false);

    }

    void Update()
    {
        if (starttime)
        {

            time -= Time.deltaTime;

            if (time <= 0)
            {
                //.SetActive(false);
                timeFinished = true;
                starttime = false;
            }
            else
            {
                timeFinished = false;
            }


            timetext.text = "Count:<" + time.ToString() + ">";
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            print("stay");
            Waitmsg.SetActive(true);
            StartTimer();
            // Destroy(gameObject);
            if (timeFinished == true)
            {
                timeobject.SetActive(false);
                Waitmsg.SetActive(false);
                // increasescore();
                can_go = true;
            }
        }
    }

    public void StartTimer()
    {
        timeobject.SetActive((true));
        starttime = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            timeobject.SetActive(false);
            Waitmsg.SetActive(false);
            if (can_go)
            {
                StartCoroutine(gainmsg());
                Waitmsg.SetActive(false);
                scoreobj.increasescore();
              //  Destroy(gameObject);
                Destroy(gameObject);

            }
            else
            {
               // car.transform.position = respawnpoint.transform.position;
                _points.highhit();
            }
        }
    }

    IEnumerator gainmsg()
    {
        //gained.text = "Gained Extra Points...Fantastic!!";
        gained.SetActive(true);
        yield return new WaitForSeconds(2);
        //gained.text = " ";
        gained.SetActive(false);
    }



}