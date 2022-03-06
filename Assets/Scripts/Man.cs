using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private Transform pos1;
    [SerializeField] private Transform pos2;


    public float speed = 10f;

    private string moveDir = "right";

    private bool lookRight = true;

    private GameManager gm;


    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

         gm = FindObjectOfType<GameManager>();

    }

    private void FixedUpdate()
    {

        if (transform.position.x <= pos1.position.x)
        {

            moveDir = "right";
            lookRight = true;

            if (lookRight)
            {

                transform.localScale *= new Vector2(-1, 1);
                lookRight = !lookRight;

            }
        }
        else if (transform.position.x >= pos2.position.x)
        {

            moveDir = "left";
            lookRight = false;

            if (!lookRight)
            {

                transform.localScale *= new Vector2(-1, 1);
                lookRight = !lookRight;

            }
        }


        if (moveDir.Equals("right"))
        {

            rb.velocity = new Vector2(speed, rb.velocity.y * Time.deltaTime);



        }
        else if (moveDir.Equals("left"))
        {

            rb.velocity = new Vector2(-speed, rb.velocity.y * Time.deltaTime);


        }




    }


    

}
