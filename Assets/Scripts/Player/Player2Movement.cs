using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Movement : MonoBehaviour
{
    private float boundary = 20.8f;
    

    [SerializeField] private Rigidbody2D rb;

    Vector2 movement;

    [SerializeField] float speed = 3f;
    [SerializeField] float jumpForce = 10f;
    private float moveInput;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    bool isGrounded;

    void Update()
    {
        movement = Vector2.zero;

        PlayerInput();

        //Player Boundaries
        if (transform.position.x < -boundary)
        {
            transform.position = new Vector2(-boundary, transform.position.y);
        }

        if (transform.position.x > boundary)
        {
            transform.position = new Vector2(boundary, transform.position.y);
        }


    }


    void PlayerInput()
    {
        moveInput = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
            moveInput = -1f;
        else if (Input.GetKey(KeyCode.RightArrow))
            moveInput = 1f;

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            FindObjectOfType<AudioManager>().Play("Jump2");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void FixedUpdate()
    {
        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    void OnDrawGizmos()
    {
        // Draw ground check radius in the scene view
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spikes"))
        {
            FindObjectOfType<AudioManager>().Play("HitSpikes");
            GameOver();
        }
    }

}
