﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callRed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
     print("Clicked Red");
     TrafficLight.sendRed();
   }
}
