using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class timer : MonoBehaviour
{
    public float totaltime=5;
    public GameObject timerText;
    [SerializeField] private Text timings;
    private bool startTimer=false;
    public bool timeFinished;
       
   // private float startingTIme;

    //public float seconds; 
    
    void Start()
    {
        timerText.SetActive(false);
        
    }

    
    void Update()
    {
        if (startTimer)
        {
            totaltime -= Time.deltaTime;
            
                if (totaltime <= 0)
                {
                    timerText.SetActive(false);
                    timeFinished = true;
                    startTimer = false;
                }
                else
                {
                    timeFinished = false;
                }
           

            timings.text = "Count:<" + totaltime.ToString()+ ">";
        }
    }

    public void StartTimer()
    {
        timerText.SetActive(true);
        startTimer = true;
    }
}
