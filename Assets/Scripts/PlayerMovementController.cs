using Microsoft.Win32;
using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerControls controls;
    [SerializeField] float speed;
    private Rigidbody2D rb;
    private bool facingRight;
    private Animator animator;
    
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask ground;
    [SerializeField] private Transform topLeftCorner;
    [SerializeField] private Transform bottomRightCorner;
    private bool doubleJumping;

    private void Awake()
    {
        controls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
        animator = GetComponent<Animator>();
    }

    void Start()
    {
    }

    private void Update()
    {
        int jumpState = animator.GetInteger("JumpState");

        if (rb.velocity.y < 0 && jumpState > 0)
        {
            //fall
            animator.SetInteger("JumpState", 3);
        }

        if (controls.Move.Jump.triggered || controls.Move.DoubleJump.triggered)
        {
            Jump();
        }

        controls.Move.Slide.performed += _ => Slide();
        controls.Move.Crouch.performed += _ => Crouch();
    }

    private void Crouch()
    {
        animator.SetTrigger("Crouching");
    }

    private void Slide()
    {
        animator.SetTrigger("Sliding");
    }

    void FixedUpdate()
    {
        float moveLeftRightInput = controls.Move.Sideways.ReadValue<float>() * speed * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(moveLeftRightInput));

        if((moveLeftRightInput < 0 && facingRight) || (moveLeftRightInput > 0 && !facingRight))
        {
            Flip();
        }
     
        Vector3 currentPos = transform.position;
        currentPos.x += moveLeftRightInput;
        transform.position = currentPos;
    }

    private void Jump()
    {
        if (doubleJumping)
        {
            return;
        }

        Vector2 velocity = rb.velocity;
        velocity.y = jumpForce;
        rb.velocity = velocity;

        int jumpState = animator.GetInteger("JumpState");
        Debug.Log($"Jump() -> jumpState = {jumpState}");

        if (jumpState == 0 || jumpState == 1)
        {
            if (jumpState == 1)
            {
                doubleJumping = true;
            }

            animator.SetInteger("JumpState", ++jumpState);          //hehehehehehe jumpState++ hehehehehe
        }
        else if(jumpState == 3)
        {
            doubleJumping = false;
        }

        Debug.Log("force added");
    }

    private void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up * 180);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetInteger("JumpState", 0);
        doubleJumping = false;
    }
}
