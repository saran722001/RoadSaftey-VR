using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerpoints : MonoBehaviour
{
   public float health = 200;
   public Text healthText;

   void start()
   {
      
      healthText.text = health.ToString();
   }
   

   public float decreaseHealth()
   {
      health -= 5;
      healthText.text = health.ToString();
      return health;

   }
}
