using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class points : MonoBehaviour
{
    public int ppoints = 200;

    public Text point;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        point.text = ppoints.ToString();
    }

    public void carhit()
    {
        ppoints = ppoints - 5;
        //point.text = ppoints.ToString();
        //return point;

    }

    public void highhit()
    {
        ppoints = ppoints - 10;
        //ppoints.text
    }
}
