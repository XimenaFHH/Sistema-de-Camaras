using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 0;
    public float rotattionSpeed = 0;

    public Animator animator;

    private float x, y;

    public Rigidbody rb;
    public float JumpHeight = 3;

    public Transform grounCheck;
    public float grounDistance = 0.1f;
    public LayerMask groundMask;

    private bool isGrounded;

    void Update()
    {
        x = Input.GetAxis("Horizontal");

        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotattionSpeed, 0);

        transform.Translate(0, 0, y * Time.deltaTime * Speed);

        animator.SetFloat("VeX", x);
        animator.SetFloat("VeY", y);

        if (Input.GetKey("e"))
        {
            animator.SetBool("Other", false);

            animator.Play("Eat");
            animator.Play("Eyes_Excited");
        }

        if (Input.GetKey("q"))
        {
            animator.SetBool("Other", false);
            
            animator.Play("Sit");
            animator.Play("Eyes_Sleep");
        }

        if (Input.GetKey("f"))
        {
            animator.SetBool("Other", false);

            animator.Play("Death");
            animator.Play("Eyes_Trauma");
        }

        if (Input.GetKey("r"))
        {
            animator.SetBool("Other", false);

            animator.Play("Spin");
            animator.Play("Eyes_Squint");
        }

        if (x>0 || x<0 || y>0 || y<0)
        {
            animator.SetBool("Other", true);
        }

        isGrounded = Physics.CheckSphere(grounCheck.position, grounDistance, groundMask);

        if(Input.GetKey("space") && isGrounded)
        {
            animator.Play("Jump");
           

            rb.AddForce(Vector3.up * JumpHeight, ForceMode.Impulse);
        }
    }
}
