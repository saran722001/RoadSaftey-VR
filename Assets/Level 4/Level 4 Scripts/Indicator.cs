using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicator : MonoBehaviour
{
    public Image LIndicator;
    public Image RIndicator;
    private bool right = false;
    private bool left = false;//,Rkey_pressed,Lkey_pressed;


    //public Image RIndicator;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        // Update is called once per frame
        if (Input.GetKey(KeyCode.G) && right == false)
        {
            left = lefton();

            LIndicator.color = Color.red;
            RIndicator.color = Color.white;
            //Lkey_pressed = true;
        }
        else if (Input.GetKey(KeyCode.H) && left == false)
        {
            right = righton();
            RIndicator.color = Color.red;
            LIndicator.color = Color.white;
            //Rkey_pressed = true;

        }
        else if (Input.GetKey(KeyCode.G) && !left)
        {


            leftoff();
        }
        else if (Input.GetKey(KeyCode.J) && !right)
        {

            rightoff();
        }
        else if(Input.GetKey(KeyCode.H))
            {
            alloff();
        }
        else
        {
            right = false;
            left = false;
        }

    }

    public bool lefton()
    {
        LIndicator.color = Color.red;
        RIndicator.color = Color.white;
        right = false;
        return right;
    }

    public bool righton()
    {
        RIndicator.color = Color.red;
        LIndicator.color = Color.white;
        left = false;
        return left;
    }

    public void leftoff()
    {
        LIndicator.color = Color.white;
    }

    public void rightoff()
    {
        RIndicator.color = Color.white;
    }
    public void alloff()
    {
        RIndicator.color = Color.white;
        LIndicator.color = Color.white;

    }

}