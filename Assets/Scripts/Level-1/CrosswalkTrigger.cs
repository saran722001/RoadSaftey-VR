using System.Collections;
using UnityEngine;

public class CrosswalkTrigger : MonoBehaviour
{
   [SerializeField] private GameObject car;
   [SerializeField] private Transform respawnpoint;
   [SerializeField] private GameObject UI;
   //[SerializeField] private GameObject outofbox;
   private bool triggered;
   points _points;

   void Start()
   {
      UI.SetActive(false);
      _points = GameObject.FindGameObjectWithTag("point").GetComponent<points>();
   }

   void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "car")
      {
         print("Triggered/n");
         _points.carhit();
         triggered = true;
         Triggered(triggered);
            car.transform.position = respawnpoint.transform.position;
      }
   }

 
  public void Triggered(bool triggered)
   {
      if (triggered)
      {
         //car.transform.position = respawnpoint.transform.position;
         
         StartCoroutine(warn());
         triggered = false;
      }
   }

  public void Outofbox(bool trig)
  {
     car.transform.position = respawnpoint.transform.position;
     _points.carhit();
    // StartCoroutine(warn2());
     
  }

   IEnumerator warn()
   {
      UI.SetActive(true);
      yield return new WaitForSeconds(3);
      UI.SetActive(false);
   }

   /*IEnumerator warn2()
   {
     // outofbox.SetActive(true);
      yield return new WaitForSeconds(3);
      //outofbox.SetActive(false);
   }*/
   
   
   
   
}