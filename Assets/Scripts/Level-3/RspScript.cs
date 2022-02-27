using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RspScript : MonoBehaviour
{
    [SerializeField] private Transform player1;
    [SerializeField] private Transform respawnpoint;
    [SerializeField] private GameObject UI;
    void Start()
    {
        UI.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
       
        player1.transform.position = respawnpoint.transform.position;
        StartCoroutine(warn());

    }
    IEnumerator warn()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(3);
        UI.SetActive(false);
    }

}
