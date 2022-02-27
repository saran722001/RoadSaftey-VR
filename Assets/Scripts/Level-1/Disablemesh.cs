using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disablemesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Renderer[] rs = GetComponentsInChildren<Renderer>();
        foreach(Renderer r in rs)
            r.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
