using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{


    private Rigidbody2D rb;

    [SerializeField] private Transform pos1;
    [SerializeField] private Transform pos2;


    private string moveDir;

    private short dir = 1;


    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        if (gameObject.tag.Equals("MoveX"))
        {

            dir = 2;
            moveDir = "right";

        }
        else
        {
            dir = 1;
            moveDir = "up";

        }
    }

    private void FixedUpdate()
    {



        if (dir == 2)
        {

            if (transform.position.x <= pos1.position.x)
            {

                moveDir = "right";

            }
            else if (transform.position.x >= pos2.position.x)
            {

                moveDir = "left";

            }


            if (moveDir.Equals("right"))
            {

                rb.velocity = new Vector2(10f, rb.velocity.y * Time.deltaTime);

            }
            else if (moveDir.Equals("left"))
            {

                rb.velocity = new Vector2(-10f, rb.velocity.y * Time.deltaTime);

            }

        }
        else if (dir == 1)
        {

            if (transform.position.y <= pos1.position.y)
            {

                moveDir = "up";

            }
            else if (transform.position.y >= pos2.position.y)
            {

                moveDir = "down";

            }


            if (moveDir.Equals("up"))
            {

                rb.velocity = new Vector2(rb.velocity.x, 500f * Time.deltaTime);

            }
            else if (moveDir.Equals("down"))
            {

                rb.velocity = new Vector2(rb.velocity.x, -500f * Time.deltaTime);

            }
        }
    }

}
        

    
