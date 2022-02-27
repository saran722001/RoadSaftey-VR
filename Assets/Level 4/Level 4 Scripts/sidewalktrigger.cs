using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidewalktrigger : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private Transform respawnpoint;

    [SerializeField] private GameObject UI;

    private bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            print("triggered");
            triggered = true;
        }
    }

    void FixedUpdate()
    {
        if (triggered)
        {
            player.transform.position = respawnpoint.transform.position;
            StartCoroutine(warncar());
            triggered = !triggered;
        }
    }

    IEnumerator warncar()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(2);
        UI.SetActive(false);
    }
}
