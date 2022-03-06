using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkCamera : MonoBehaviour
{

    [SerializeField] private Animator anim;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag.Equals("Player"))
        {

            anim.SetBool("inDark", true);

        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("Player"))
        {

            anim.SetBool("inDark", false);

        }

    }

}
