using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //i want the exposition of my game object to appear on the console
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f);
    }
    
    
    // Update is called once per frame
    void Update()
    {
      //I want to know what my y location is at all times
     //Debug.Log (transform.position.y);

        //I want the console to say something if my object is below 5
        
    }
    
   
}
