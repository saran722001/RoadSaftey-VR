using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endpoint : MonoBehaviour
{
    private int check=0;
    //public GameObject UI;
    private float ppoint;
    playerpoints _playerpoints;
    public GameObject endmesg;
    private float updatedscore;
    private float updatedscore2;
    private Text endmsg;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerpoints = GameObject.FindGameObjectWithTag("score").GetComponent<playerpoints>();
        //UI.SetActive(false);
        ppoint = _playerpoints.decreaseHealth();
        endmesg = GameObject.FindGameObjectWithTag("endmsg");
        endmsg = endmesg.GetComponent<Text>();
        endmesg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        updatedscore = 1000 - updatescore.score;
        updatedscore2 = 100 - ppoint;
        Debug.Log(ppoint);
        Debug.Log(updatescore.score);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (updatescore.score >= 1000 && ppoint>=100)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                StartCoroutine(endpointmessage());
            }
        }

        
        
    }

    IEnumerator endpointmessage()
    {
        
        
        if (updatescore.score < 1000)
        {
            endmsg.text = "Your Score is "+updatescore.score+ "You need "+updatedscore+ "more";
        }

        if (ppoint < 100)
        {
            endmsg.text = "Your Score is "+ppoint+ "You need "+updatedscore2+ "more";
        }
        endmesg.SetActive(true);
        yield return new WaitForSeconds(3);
        endmesg.SetActive(false);

    }
}
