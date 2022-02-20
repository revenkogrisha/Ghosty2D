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

        for (int i = 0; i < buttons.Length; i++)
        {

            if ( PlayerPrefs.GetInt("Crystals") >= i )
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
