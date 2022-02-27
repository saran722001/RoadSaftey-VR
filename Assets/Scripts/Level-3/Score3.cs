using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class Score3 : MonoBehaviour
{
    public int s;
    public AudioSource Ad;
    void Update()
    {
        s = ScoreText.score;
    
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ad.Play();
            ScoreText.score += 50;
            Destroy(gameObject);
        }

    }
}
