using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Shine : MonoBehaviour
{
    public Transform shineSize;
    bool rangeControl = false;
    float timer = 5f;


    void Start()

    {
        
    }
    void Update()
    {

        //shineSize.localScale += new Vector3(0.01f, 0.01f, 0f);
        //  shineSize.eulerAngles += new Vector3(1f, 1f, 1f);
        shineSize.Rotate(new Vector3(0f, 0f, 0.3f));
        if (rangeControl == false)
        {
            shineSize.localScale += new Vector3(0.00023f, 0.00023f, 0f);
            timer -= Time.deltaTime;

        }
        else
        {
            shineSize.localScale += new Vector3(-0.00023f, -0.00023f, 0f);
            timer -= -1 * Time.deltaTime;
        }

        if (timer <= 1f)
        {
            rangeControl = true;
        }
        else if (timer >= 5f)
        {
            rangeControl = false;
        }
        

    }

}

