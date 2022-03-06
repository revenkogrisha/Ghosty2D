using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinUnlocker : MonoBehaviour
{

    [SerializeField] private Button[] buttons;
    [SerializeField] private GameObject[] images;


    public ImageManager im;


    private void Start()
    {

        SkinsCheck();

    }





    public void SkinsCheck()
    {

        for (int i = 0; i < buttons.Length; i++)
        {

            if (PlayerPrefs.GetInt("Crystals") >= i && i == 0)
            {

                buttons[i].interactable = true;
                Destroy(images[i]);

            }
            else if (PlayerPrefs.GetInt("Crystals") > i)
            {

                buttons[i].interactable = true;
                Destroy(images[i]);

            }


        }

    }

    public void SetSkin(int skinNum)
    {

        PlayerPrefs.SetInt("Skins", skinNum);
        im.SetImage();

    }

}
