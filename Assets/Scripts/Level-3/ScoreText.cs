using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreText : MonoBehaviour
{
    public Text scoretext;
    public int s;

    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        //scoretext = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        s = score;
        scoretext.text = score.ToString();
    }
}
