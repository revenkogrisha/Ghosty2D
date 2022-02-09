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

    public int crystals;


    

    private void Start()
    {
        haveKey = false;

        gameHasEnded = false;

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
    }

    public void UnlockLevel()
    {


        if (SceneManager.GetActiveScene().buildIndex == 3 && PlayerPrefs.GetInt("levels") < 2)
        {
            Debug.Log("Unlock");
            PlayerPrefs.SetInt("levels", 2);
            SceneManager.LoadScene(0);

        }
        


    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
        
    }

}
