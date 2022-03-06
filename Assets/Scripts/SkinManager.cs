using UnityEngine;

public class SkinManager : MonoBehaviour
{

    [SerializeField] private SpriteRenderer hatSkin;
    [SerializeField] public Sprite[] hats;

    private Sprite sprite;


    void Start()
    {
        
        switch (PlayerPrefs.GetInt("Skins"))
        {

            case 0:
                sprite = hats[0];
                break;

            case 1:
                sprite = hats[1];
                break;

            case 2:
                sprite = hats[2];
                break;

        }

        hatSkin.sprite = sprite;

    }

}
