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
        float movement = Input.GetAxisRaw("Horizontal" + playerNum);
        float speedChange = movement * moveSpeed;

        if (Mathf.Abs(playerRigid.velocity.x + speedChange) >= maxSpeed)
        {
            playerRigid.velocity = new Vector2(maxSpeed * movement, playerRigid.velocity.y);
        }
        else
        {
            playerRigid.velocity = new Vector2(playerRigid.velocity.x + speedChange, playerRigid.velocity.y);
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
