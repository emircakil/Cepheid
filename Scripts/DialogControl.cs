using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogControl : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject secondDialog;
    public GameObject thirdDialog;
    public GameObject fourthDialog;


    void Start()
    {
       secondDialog.SetActive(false);
        thirdDialog.SetActive(false);
        fourthDialog.SetActive(false);
    }

    void Update()
    {
        if (playerTransform.position.x >= 6.7 && playerTransform.position.x <= 25) { 
        
            secondDialog.SetActive(true);
        }
        if (playerTransform.position.x >= 31 && playerTransform.position.x <= 47) { 
        
            thirdDialog.SetActive(true);
        }
        if (playerTransform.position.x >= 57) {

            fourthDialog.SetActive(true);
        }
        


    }
}
