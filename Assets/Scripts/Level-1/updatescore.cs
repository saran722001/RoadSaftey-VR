using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updatescore : MonoBehaviour
{
    public Text scoretext;

    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        //scoretext = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
    }
}
