using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{

    
    public Animator animKey;
    private bool isCollected;


    private void Start()
    {
        isCollected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (gameObject.tag.Equals("Key") && collision.gameObject.tag.Equals("Player") && isCollected == false)
        {

            //Запускает анимацию 
            animKey.SetTrigger("isCollected");

            //Уничтожает объект
            //Destroy(gameObject);

            //Добавляет +1 в счетчик
            FindObjectOfType<GameManager>().haveKey = true;

            isCollected = true;
        }
        
    }


   

}

