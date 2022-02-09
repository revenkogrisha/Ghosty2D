using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrCollect : MonoBehaviour
{

    public Animator anim;

    private bool isCollected;


    private void Start()
    {

        isCollected = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("Player") && isCollected == false)
        {

            anim.SetBool("isCollected", true);

            FindObjectOfType<GameManager>().crystals += 1;

            isCollected = true;

        }

    }

}
