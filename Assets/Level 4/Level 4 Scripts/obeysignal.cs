using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obeysignal : MonoBehaviour
{
    private TrafficLights _trafficLights;
    public GameObject msg;
    private bool trig;

    private int light;
    // Start is called before the first frame update
    void Start()
    {
        _trafficLights = GameObject.FindGameObjectWithTag("firstT").GetComponent<TrafficLights>();
        msg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        light = _trafficLights.tState.status;
        if (trig == true && light==41)
        {
            red();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //print("triggered");
        if (other.gameObject.tag == "car")
        {
            trig = true;
            print("triggered");
            /*if (light == 41)
            {
                print("triggered");
                red();
                
            }*/
            
        }
    }

    void red()
    {
        
        StartCoroutine(redsignal());
        
    }


    IEnumerator redsignal()
    {
        msg.SetActive(true);
        yield return new WaitForSeconds(3);
        msg.SetActive(false);
        trig = false;
    }
}
