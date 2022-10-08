using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 3f;
    private float jumpingPower = 7f;
    private bool isFacingRight = true;
    public Animator animator;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        
        animator.SetBool("GroundCheck", IsGrounded());

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) { 
        
            rb.velocity = new Vector2 (rb.velocity.x , jumpingPower);
        }

        if (Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0f) { 
        
            rb.velocity = new Vector2 (rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded() { 
    
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip() {

        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f) {

            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        
        }
    }

}
