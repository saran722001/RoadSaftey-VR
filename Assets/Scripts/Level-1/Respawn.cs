using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    public Transform respawnpoint;
    [SerializeField] private GameObject UI;
    public bool triggered;
    playerpoints playerpoint;
    public AudioSource aud;

    void Start()
    {
        
        playerpoint = GameObject.FindGameObjectWithTag("score").GetComponent<playerpoints>();
        UI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            aud.Play();
            Debug.Log("Trigger");
            triggered = true;
            
            //UI.SetActive(true);
        }

    }

    void FixedUpdate()
    {
        if (triggered==true)
        {
            player.transform.position = respawnpoint.transform.position;
            StartCoroutine(warningmsg());
            playerpoint.decreaseHealth();
            triggered = false;

        }
        
    }

    IEnumerator warningmsg()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(2);
        UI.SetActive(false);
    }
}