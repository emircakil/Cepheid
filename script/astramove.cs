using UnityEngine;

public class astramove : MonoBehaviour
{
    public Transform astra;
    public float moveSpeed = 0.1f;
    

    private void Start()
    {
    
    }
    private void Update()
    {
 
        astra.Translate(new Vector2(1f, 0f) * -moveSpeed * Time.deltaTime);
       
    }

}
