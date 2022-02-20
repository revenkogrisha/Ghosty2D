using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
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

            //Запускает анимацию 
            anim.SetTrigger("GemCollected");

            //Уничтожает объект
            //Destroy(gameObject);

            //Добавляет +1 в счетчик
            FindObjectOfType<GameManager>().gemCount += 1;

            isCollected = true;

        }
        
        
    }


   

}

