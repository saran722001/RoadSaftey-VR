using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvl3credits : MonoBehaviour
{
    public float health = 200;
    public Text healthText;
   public float h;

    void start()
    {
      
        healthText.text = health.ToString();
    }

    void Update()
    {
        h = health;
       healthText.text = h.ToString();

    }
   

    public void decreaseHealth()
    {
        health -= 5;
        //healthText.text = h.ToString();
        //healthText.text = health.ToString();
        //return health;

    }
}