using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDestination : MonoBehaviour
{
    [SerializeField] private GameObject Ld;
    void Start()
    {
        Ld.SetActive(false);
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            StartCoroutine(Led());

        }
    }
    IEnumerator Led()
    {
        Ld.SetActive(true);
        yield return new WaitForSeconds(5);
        Ld.SetActive(false);
    }

}
