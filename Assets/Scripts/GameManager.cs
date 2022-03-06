using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameHasEnded;

    public int gemCount;

    public Text gemText;

    public Animator anim;

    public Animator vcam;

    public bool haveKey;

    public bool unlockRed;
    public bool unlockBlue;

    public int crystals;




    

    private void Start()
    {
        haveKey = false;

        gameHasEnded = false;

        unlockRed = false;
        unlockBlue = false;

        crystals = 0;
    }


    private void Update()
    {

        gemText.text = gemCount.ToString() + "/" + 3;


    }
    

    


    //                                  Methods 

    public void EndGame()
    {
        gameHasEnded = true;
        anim.SetBool("gameEnded", true);
        vcam.SetBool("isDead", true);

        Invoke("Restart", 3f);
    }

    public void ExitGame()
    {

        SceneManager.LoadScene("MainMenu");

    }

    public void Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



        //Crystals

        if(SceneManager.GetActiveScene().buildIndex == 1 && crystals > PlayerPrefs.GetInt("M1L1"))
        {
            PlayerPrefs.SetInt("M1L1", crystals);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2 && crystals > PlayerPrefs.GetInt("M1L2"))
        {
            PlayerPrefs.SetInt("M1L2", crystals);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4 && crystals > PlayerPrefs.GetInt("M2L1"))
        {
            PlayerPrefs.SetInt("M2L1", crystals);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5 && crystals > PlayerPrefs.GetInt("M2L2"))
        {
            PlayerPrefs.SetInt("M2L2", crystals);
        }
        

    }

    public void UnlockLevel()
    {


        if (SceneManager.GetActiveScene().buildIndex == 3 && PlayerPrefs.GetInt("levels") < 2)
        {
            PlayerPrefs.SetInt("levels", 2);
            SceneManager.LoadScene(0);

            if (crystals > PlayerPrefs.GetInt("M1L3"))
            {

                PlayerPrefs.SetInt("M1L3", crystals);
                
            }


        }
        else if (SceneManager.GetActiveScene().buildIndex == 6 && PlayerPrefs.GetInt("levels") < 3)
        {
            PlayerPrefs.SetInt("levels", 3);
            SceneManager.LoadScene(0);

            if (crystals > PlayerPrefs.GetInt("M2L3"))
            {

                PlayerPrefs.SetInt("M2L3", crystals);

            }


        }
        


    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
        
    }

}
