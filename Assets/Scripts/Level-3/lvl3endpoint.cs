using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lvl3endpoint : MonoBehaviour
{
    ScoreText s;
    private int check=0;
    //public GameObject UI;
    //private float ppoint;
    //lvl3credits _playerpoints;
    public GameObject endmesg;
    private float updatedscore;
  //private float updatedscore2;
   public Text endmsg;
    
    // Start is called before the first frame update
    void Start()
    {
       // _playerpoints = GameObject.FindGameObjectWithTag("credits").GetComponent<lvl3credits>();
        //UI.SetActive(false);
      //  ppoint = _playerpoints.h;
       // endmesg = GameObject.FindGameObjectWithTag("end");
        //endmsg = endmesg.GetComponent<Text>();
        endmesg.SetActive(false);
        s = GameObject.FindGameObjectWithTag("score").GetComponent<ScoreText>();

    }

    // Update is called once per frame
    void Update()
    {
      updatedscore = 1500 - s.s;
        //updatedscore2 = 100 - ppoint;
        Debug.Log(updatedscore);
       // Debug.Log(updatescore.s);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("u score is" + updatedscore);
            if (s.s>1500)
            {
                SceneManager.LoadScene(8);
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
        if (s.s < 1500)
         {
             endmsg.text = "Your Score is "+s.s+ "You need "+updatedscore+ "more";
         }

       /* if (ppoint < 100)
        {
            endmsg.text = "Your Score is "+ppoint+"You need "+updatedscore2+ "more";
        }
       */

    }
}