using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float jumpPower;
    [SerializeField] private int extraJump = 0;

    Rigidbody2D rb2d;
    CircleCollider2D cir2d;
    Animator animator;

    public GameObject CollY;
    private ColY colY_script;
    public GameObject collX;
    private ColX colX_script;
    public GameObject collL;
    private ColL colL_script;

    public bool facingR;
    private bool idle;
    private bool movR;
    private bool movL;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cir2d = GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();
        colY_script = CollY.GetComponent<ColY>();
        colX_script = collX.GetComponent<ColX>();
        colL_script = collL.GetComponent<ColL>();
    }

    private void Update()
    {
        if(isGrounded())
        {
            extraJump = 1;

            if (Input.GetKeyDown(KeyCode.C))
            {               
                jump();
            }
        }
        else
        {
            if (extraJump > 0 && Input.GetKeyDown(KeyCode.C))
            {
                jump();
                extraJump--;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            facingR = true;
            movR = true;
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            movR = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            facingR = false;
            movL = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            movL = false;
        }


        animator.SetFloat("velY", rb2d.velocity.y);
        animator.SetBool("isGrounded", isGrounded());
        animator.SetBool("movR", movR);
        animator.SetBool("movL", movL);
        animator.SetBool("facingRight", facingR);
    }

    private void jump()
    {
        rb2d.velocity = new Vector2(0, 0);
        rb2d.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
    }

    public bool isGrounded()
    {
        if (colY_script.colOnY == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
