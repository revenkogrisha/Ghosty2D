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
        PlayerPrefs.SetInt("Crystals", (PlayerPrefs.GetInt("M1L1") + PlayerPrefs.GetInt("M1L2") + PlayerPrefs.GetInt("M1L3")
            + PlayerPrefs.GetInt("M2L1") + PlayerPrefs.GetInt("M2L2")));

        crText.text = $"{PlayerPrefs.GetInt("Crystals").ToString()}/5";
    }




    public void PlayGame(int levelNumb)
    {

        SceneManager.LoadScene(levelNumb);

    }

    public void DeleteProgress()
    {
        //          Crystals
        PlayerPrefs.SetInt("Crystals", 0);
        PlayerPrefs.SetInt("M1L1", 0);
        PlayerPrefs.SetInt("M1L2", 0);
        PlayerPrefs.SetInt("M1L3", 0);
        PlayerPrefs.SetInt("M2L1", 0);
        PlayerPrefs.SetInt("M2L2", 0);


        //           Skins
        PlayerPrefs.SetInt("Skins", 0);


        //         Maps Lock
        PlayerPrefs.SetInt("levels", 1);
        levelManager.levelUnlock = 1;
        SceneManager.LoadScene(0);


        //         Jump Force
        PlayerPrefs.DeleteKey("JumpForce");
    }

}
