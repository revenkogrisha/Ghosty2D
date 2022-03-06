using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    private GameManager gm;
    private Player player;


    public Animator advTxt;



    private void Awake()
    {

        gm = FindObjectOfType<GameManager>();
        player = GetComponent<Player>();

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag.Equals("DeadLine"))
        {

            gm.EndGame();
            
        }
        else if ( collision.gameObject.tag.Equals("Finish") && ( SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 6) )
        {

            gm.UnlockLevel();

        }
        else if(collision.gameObject.tag.Equals("Finish"))
        {

            gm.Finish();
            
        }
        else if(collision.gameObject.tag.Equals("JumpUpgrade"))
        {

            collision.gameObject.GetComponentInChildren<Animator>().SetBool("isCollected", true);
            PlayerPrefs.SetInt("JumpForce", 23);
            player.CheckJump();
            
        }
        else if (collision.gameObject.tag.Equals("Man"))
        {

            gm.EndGame();

        }
        else if (collision.gameObject.tag.Equals("Advice"))
        {

            advTxt.SetBool("Trigger", true);

        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag.Equals("FinishBlock") && gm.gemCount >= 3)
        {

            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag.Equals("KeyBlock") && gm.haveKey)
        {

            Destroy(collision.gameObject);

        }

        //                                               COLOR_LOCKS

        else if (collision.gameObject.tag.Equals("ColorLock") && collision.gameObject.GetComponent<SpriteRenderer>().color == Color.red && gm.unlockRed)
        {

            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag.Equals("ColorLock") && collision.gameObject.GetComponent<SpriteRenderer>().color == Color.blue && gm.unlockBlue)
        {

            Destroy(collision.gameObject);

        }

        //                                                 CRYSTALS

        else if (collision.gameObject.tag.Equals("Crystal") && SceneManager.GetActiveScene().buildIndex == 1)
        {

            Destroy(collision.gameObject);
            gm.crystals += 1;

        }
        else if (collision.gameObject.tag.Equals("Crystal") && SceneManager.GetActiveScene().buildIndex == 2)
        {

            gm.crystals += 1;
            Destroy(collision.gameObject);

        }


    }


    
}
    