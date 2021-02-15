using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerNum;
    public BoxCollider2D feet;
    public float moveSpeed = 1f;
    public float maxSpeed = 10f;
    public float jumpForce = 35f;
    public Transform spawn;
    public GameObject playerCamera;

    private Rigidbody2D playerRigid;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float movement = Input.GetAxisRaw("Horizontal" + playerNum);
        float speedChange = movement * moveSpeed;
        float currentSpeed = playerRigid.velocity.x;

        if (Mathf.Abs(currentSpeed + speedChange) >= maxSpeed)
        {
            playerRigid.velocity = new Vector2(maxSpeed * movement, playerRigid.velocity.y);
        }
        else if (movement != 0)
        {
            playerRigid.AddForce(new Vector2(speedChange, 0f), ForceMode2D.Impulse);
        }
        else
        {
            float newSpeed = currentSpeed -moveSpeed;
            if (Mathf.Sign(newSpeed) != Mathf.Sign(currentSpeed)) { newSpeed = 0f; };
            playerRigid.velocity = new Vector2(newSpeed, playerRigid.velocity.y);
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            playerRigid.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    // For checking whether player is grounded
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
