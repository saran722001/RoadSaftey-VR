﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastscript : MonoBehaviour
{
    

    
    // Update is called once per frame
    void Update()
    {
    RaycastHit hit;
    Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
    Debug.DrawRay(transform.position, forward, Color.green);
        if (Physics.Raycast(transform.position, forward, out hit))
        {
            print(hit.collider.gameObject.name);
        }
    }
}
