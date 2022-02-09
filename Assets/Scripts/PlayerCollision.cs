using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag.Equals("DeadLine"))
        {

            FindObjectOfType<GameManager>().EndGame();
            
        }
        else if (collision.gameObject.tag.Equals("Finish") && SceneManager.GetActiveScene().buildIndex == 3)
        {

            Debug.Log("Collision");
            FindObjectOfType<GameManager>().UnlockLevel();

        }
        else if(collision.gameObject.tag.Equals("Finish"))
        {

            FindObjectOfType<GameManager>().Finish();
            
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag.Equals("FinishBlock") && FindObjectOfType<GameManager>().gemCount >= 3)
        {

            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag.Equals("KeyBlock") && FindObjectOfType<GameManager>().haveKey)
        {

            Destroy(collision.gameObject);

        }

        //                                                 CRYSTALS

        else if (collision.gameObject.tag.Equals("Crystal") && SceneManager.GetActiveScene().buildIndex == 1)
        {

            Destroy(collision.gameObject);
            FindObjectOfType<GameManager>().crystals += 1;

        }
        else if (collision.gameObject.tag.Equals("Crystal") && SceneManager.GetActiveScene().buildIndex == 2)
        {

            FindObjectOfType<GameManager>().crystals += 1;
            Destroy(collision.gameObject);

        }


    }


    
}
    