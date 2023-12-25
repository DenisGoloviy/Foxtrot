using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 5f;
    private float currentSpeed;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;

    public float playerStamina;
    [SerializeField] private float maxStamina = 11f;

    [HideInInspector] public bool hasRegenerated = true;
    [HideInInspector] public bool isSprinting = false;

    [SerializeField] private float staminaDrain = 1f;
    [SerializeField] private float staminaRegen = 0.5f;

    [SerializeField] private float runSpeed = 15f;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
        }

        if (isSprinting == true)
        {
            if(playerStamina > 0f)
            {
                playerStamina -= staminaDrain * Time.deltaTime;
                currentSpeed = runSpeed;
            }
        }
        if (isSprinting == false)
        {
            if (playerStamina < 100f)
            {
                playerStamina += staminaRegen * Time.deltaTime;
                currentSpeed = speed;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * currentSpeed, rb.velocity.y);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void Start()
    {
        playerStamina = maxStamina;
    }
}

