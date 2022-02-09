using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    public int levelUnlock;

    public Button[] buttons;


    


    void Start()
    {
        if (PlayerPrefs.HasKey("levels"))
        {

            levelUnlock = PlayerPrefs.GetInt("levels");

        }
        else
        {
            levelUnlock = 1;
        }


        for (int i = 0; i < levelUnlock; i++)
        {
            if (i < buttons.Length && !buttons[i].interactable)
            {

                buttons[i].interactable = true; 
                
            }

        }



    }


}
