using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightScript : MonoBehaviour
{
    public Light pointLight;
    float timer = 5f;
    bool rangeControl = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (rangeControl == false)
        {
            timer -= Time.deltaTime;

        }
        else {
            timer -= -1*Time.deltaTime;

        }

        if (timer <= 1f)
        {
            rangeControl = true;
        }
        else if (timer >= 5f) {
            rangeControl = false;
        }
        pointLight.range = timer;
     
    }
}
