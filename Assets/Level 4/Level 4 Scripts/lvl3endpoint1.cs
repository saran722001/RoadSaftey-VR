using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lvl3endpoint1 : MonoBehaviour
{
   // updatescore s;
    private int check=0;
    //public GameObject UI;
    private float ppoint;
    points _points;
    public GameObject endmesg;
    private float updatedscore;
  private float updatedscore2;
   public Text endmsg;
    
    // Start is called before the first frame update
    void Start()
    {
       _points = GameObject.FindGameObjectWithTag("point").GetComponent<points>();
        //UI.SetActive(false);
      ppoint = _points.ppoints;
       // endmesg = GameObject.FindGameObjectWithTag("end");
        //endmsg = endmesg.GetComponent<Text>();
        endmesg.SetActive(false);
       // s = GameObject.FindGameObjectWithTag("scoreboard").GetComponent<updatescore>();

    }

    // Update is called once per frame
    void Update()
    {
      updatedscore = 1500 - updatescore.score;
        updatedscore2 = 100 - ppoint;
        Debug.Log(updatedscore);
       // Debug.Log(updatescore.s);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            print("pp" + ppoint+ "s" + updatescore.score);
           // print("u score is" + updatescore.score);
            if (updatescore.score>1500&&ppoint>=100)
            {
                SceneManager.LoadScene(11);
                return;
            }
            else
            {
                StartCoroutine(endpointmessage());
            }
        }

        
        
    }

    IEnumerator endpointmessage()
    {
        endmesg.SetActive(true);
        yield return new WaitForSeconds(3);
        endmesg.SetActive(false);
        if (updatescore.score < 1500)
         {
             endmsg.text = "Your Score is "+updatescore.score+ "You need "+updatedscore+ "more";
         }

       if (ppoint < 100)
        {
            endmsg.text = "Your Score is "+ppoint+"You need "+updatedscore2+ "more";
        }
       

    }
}