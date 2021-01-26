using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Manager : MonoBehaviour
{
    private Rigidbody2D playerRigid;
    public float moveSpeed = 3f;
    public float jumpForce = 35f;
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigid.AddForce(new Vector2(-moveSpeed, 0f), ForceMode2D.Impulse);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigid.AddForce(new Vector2(moveSpeed, 0f), ForceMode2D.Impulse);
        }
        else
        {
            playerRigid.velocity = new Vector2(0f, playerRigid.velocity.y);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            playerRigid.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
