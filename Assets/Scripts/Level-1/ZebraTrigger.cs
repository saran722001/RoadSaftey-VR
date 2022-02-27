using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZebraTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Zt;
    public AudioSource ad;
    void Start()
    {
        Zt.SetActive(false);
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            ad.Play();
            StartCoroutine(Zet());

        }
    }
    IEnumerator Zet()
    {
        Zt.SetActive(true);
        yield return new WaitForSeconds(2);
        Zt.SetActive(false);
    }



   
}
