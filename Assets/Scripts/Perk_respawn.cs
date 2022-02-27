using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perk_respawn : MonoBehaviour
{
    public GameObject UI;
    public GameObject Car;
    [SerializeField] Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            print("respawn");
            Car.transform.position = spawnpoint.transform.position;
            StartCoroutine(stopmsg());
        }
    }
    IEnumerator stopmsg()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(3);
        UI.SetActive(false);


    }
}
