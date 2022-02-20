using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlock : MonoBehaviour
{

    GameManager gm;

    private void Awake()
    {

        gm = FindObjectOfType<GameManager>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<SpriteRenderer>())
        {

            if (gameObject.GetComponent<SpriteRenderer>().color == collision.gameObject.GetComponent<SpriteRenderer>().color)
            {

                if (gameObject.GetComponent<SpriteRenderer>().color == Color.red)
                {

                    gm.unlockRed = true;
                    Debug.Log("RED");

                }
                else if (gameObject.GetComponent<SpriteRenderer>().color == Color.blue)
                {

                    gm.unlockBlue = true;
                    Debug.Log("BLUE");

                }

            }

        }

    }


}
