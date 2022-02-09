using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public LevelManager levelManager;

    [SerializeField] private Text crText;


    
    void Start()
    {
        crText.text = $"{(PlayerPrefs.GetInt("M1L1") + PlayerPrefs.GetInt("M1L2")).ToString()}/4";
    }




    public void PlayGame(int levelNumb)
    {

        SceneManager.LoadScene(levelNumb);

    }

    public void DeleteProgress()
    {
        //          Crystals
        PlayerPrefs.SetInt("M1L1", 0);
        PlayerPrefs.SetInt("M1L2", 0);


        //         Maps Lock
        PlayerPrefs.SetInt("levels", 1);
        levelManager.levelUnlock = 1;
        SceneManager.LoadScene(0);
    }

}
