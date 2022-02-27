using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LRIndicators : MonoBehaviour
{
    public Image LIndicator;
    public Image RIndicator;

    private bool left,right,off;
   // private bool Right, Left;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        left = Input.GetKey(KeyCode.G);
        right = Input.GetKey(KeyCode.J);
        off = Input.GetKey(KeyCode.H);
            if (left)
            {
                LIndicator.color = Color.red;
                RIndicator.color = Color.white;
                //Right = false;
            }

            if (right)
            {
                LIndicator.color = Color.white;
                RIndicator.color = Color.red;
                //Left = false;
            }

            if (off)
            {
                LIndicator.color = Color.white;
                RIndicator.color = Color.white;
            }
            

            
    }
}
