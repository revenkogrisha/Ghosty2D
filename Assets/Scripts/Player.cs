using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;
    bool lookRight;

    private Rigidbody2D rb;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;


    private Animator anim;
    public Joystick joystick;

    

    private void Start()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {

        //Передвижение
        //moveInput = Input.GetAxis("Horizontal");
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        

        //Поворот
        Reflect();

        //Анимация бега
        if(moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    private void Update()
    {

        float verticalMove = joystick.Vertical;

        //Прыжок
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if(isGrounded == true && /* Input.GetKeyDown(KeyCode.Space) */ verticalMove >= .5f)
        {
            rb.velocity = Vector2.up * jumpForce;

            //Анимация прыжка
            anim.SetTrigger("takeOf");
        }

        if(isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }
    }


    void Reflect()
    {

        if ((moveInput < 0 && !lookRight) || (moveInput > 0 && lookRight))
        {

            transform.localScale *= new Vector2(-1, 1);
            lookRight = !lookRight;

        }

    }


}
