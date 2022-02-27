using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorepoints : MonoBehaviour
{
    public AudioSource cling;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            cling.Play();
            updatescore.score += 10;
            Destroy(this.gameObject);
        }
    }

    public void increasescore()
    {
        cling.Play();
        updatescore.score += 20;
    }
}
