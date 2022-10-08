using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgorundScript : MonoBehaviour
{
    public Transform asters;
    public float moveSpeed = -5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        asters.Translate(new Vector2(1f, 0f) * moveSpeed * Time.deltaTime);
      /*  if (asters.position.x <= -25) {
            Destroy(this.gameObject);
        }
      */
    }
}
