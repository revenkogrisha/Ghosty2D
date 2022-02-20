using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{

    public Image image;

    [SerializeField] private Sprite[] hats;

    private Sprite sprite;



    private void Start()
    {

        SetImage();

    }


    public void SetImage()
    {

        switch (PlayerPrefs.GetInt("Skins"))
        {

            case 0:
                sprite = hats[0];
                break;

            case 1:
                sprite = hats[1];
                break;

        }

        image.sprite = sprite;
        image.SetNativeSize();

    }

}
