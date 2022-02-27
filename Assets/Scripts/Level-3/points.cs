using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points:MonoBehaviour
{
    public int ppoints = 100;

    public Text point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void carhit()
    {
        ppoints = ppoints - 5;
        point.text = ppoints.ToString();
        //return point;

    }
}
