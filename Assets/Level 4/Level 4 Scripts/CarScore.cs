/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarScore : MonoBehaviour
{
    [SerializeField]
    private GameObject Waitmsg;

    [SerializeField] private Text gained;
    public timer timescript;
    

    CrosswalkTrigger getrespawn;
    private bool can_go=false;
  //  private Scoringsystem scoreboard;
    
    void Start()
    {
        Waitmsg.SetActive(false);
       timescript= GameObject.FindGameObjectWithTag("timings").GetComponent<timer>();
        getrespawn = GameObject.FindGameObjectWithTag("sidewalk").GetComponent<CrosswalkTrigger>();
        print("set");
        //scoreboard = 

    }

    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            print("stay");
            Waitmsg.SetActive(true);
            timescript.StartTimer();
           // Destroy(gameObject);
            if (timescript.timeFinished==true)
            {
                Waitmsg.SetActive(false);
               // increasescore();
                can_go=true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            Waitmsg.SetActive(false);
            if (can_go)
            {
                StartCoroutine(gainmsg());
                Waitmsg.SetActive(false);
                this.gameObject.GetComponent<Scoringsystem>().IncreaseScore();

            }
            else
            {
                getrespawn.Outofbox(true);
            }
        }
    }

    IEnumerator gainmsg()
    {
        gained.text = "Gained Extra Points...Fantastic!!";
        yield return new WaitForSeconds(2);
        gained.text = " ";
    }

    
    
}*/
