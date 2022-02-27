using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sidewalkscript : MonoBehaviour
{
    [SerializeField] private GameObject car;
   // [SerializeField] private Transform respawnpoint;
    [SerializeField] private GameObject UI;
    private bool triggered;
    private lvl3credits credit;
    public AudioSource ads;


    void Start()
    {
        UI.SetActive(false);
        //_points = GameObject.FindGameObjectWithTag("point").GetComponent<points>();
        ///s = SceneManager.GetActiveScene();
       // credit = GameObject.FindGameObjectWithTag("credit").GetComponent<lvl3credits>();
    }


    public void OnTriggerEnter(Collider other)
    {
       // if (other.gameObject.tag == "Player")
        //{
            //print("hi");
            credit.decreaseHealth();
            ScoreText.score = 0;
            // car.transform.position = respawnpoint.transform.position;
            SceneManager.LoadScene(7);
            StartCoroutine(warn());


        //}
    }


    public void trigger()
    {
        /*//print("hi");
        credit.decreaseHealth();
        ScoreText.score = 0;
        // car.transform.position = respawnpoint.transform.position;
        SceneManager.LoadScene(7);
        StartCoroutine(warn());*/

    }

    IEnumerator warn()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(3);
        UI.SetActive(false);
    }
}