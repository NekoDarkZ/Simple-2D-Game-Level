using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region CLASS_VARIABLES

    [SerializeField] private LayerMask layerMask;

    private Rigidbody2D rb2D;

    private Animator anim;

    private SpriteRenderer spRender;

    private CapsuleCollider2D box;

    public float movementSpeed;

    public float jumpSpeed;

    public bool isGrounded = true;

    private float horizontalInput;

    [SerializeField] Transform groundCheck;

    #endregion

    #region UNITY_METHODS

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spRender = GetComponent<SpriteRenderer>();
        box = GetComponent<CapsuleCollider2D>();
    }

    private void Update()
    {
        PlayerInputs();
        anim.SetFloat("Speed", horizontalInput);
    }

    private void FixedUpdate()
    {
        Move();
        canJump();

        if(isGrounded && Input.GetKey(KeyCode.W))
        {
            Jump();
        }
    }

    #endregion

    #region CLASS_METHODS

    public void PlayerInputs()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    public void Move()
    {
        if(horizontalInput > 0)
        {
            rb2D.velocity = new Vector2(horizontalInput * movementSpeed, rb2D.velocity.y);
            spRender.flipX = true;
        }
        else if(horizontalInput < 0)
        {
            rb2D.velocity = new Vector2(horizontalInput * movementSpeed, rb2D.velocity.y);
            spRender.flipX = false;
        }
    }

    public void Jump()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
    }

    public void canJump()
    {
        if(Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
            anim.SetBool("isGrounded", true);
        }
        else
        {
            isGrounded = false;
            anim.SetBool("isGrounded", false);
        }
    }
    #endregion
}
