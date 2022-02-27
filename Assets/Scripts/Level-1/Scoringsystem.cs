using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoringsystem : MonoBehaviour
{
    public AudioSource ad;

   // updatescore Updatescore;
    void Start()
    {
       // Updatescore = GameObject.FindGameObjectsWithTag("scoring").GetComponent<updatescore>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ad.Play();
            print("trig");
            updatescore.score += 10;
            Destroy(gameObject);
        }
            
    }

    public void IncreaseScore()
    {
        updatescore.score += 20;
    }

    /*public void normalincrease()
    {
        updatescore.score += 10;
    }*/
    
}
