using UnityEngine;
using UnityEngine.UI;

public class langMain : MonoBehaviour
{
    int numberL;

    public Sprite[] changeLang = new Sprite[2];

    private void Start()
    {
        numberL = PlayerPrefs.GetInt("numberL", 0); 

        if (numberL == 0) // USA
            GetComponent<Image>().sprite = changeLang[numberL];

        else             // RUSSIA
            GetComponent<Image>().sprite = changeLang[numberL];
    }

    public void changeLangF()
    {
        numberL++;
        numberL %= 2;

        if (numberL == 0) // USA
            GetComponent<Image>().sprite = changeLang[numberL];

        else              // RUSSIA
            GetComponent<Image>().sprite = changeLang[numberL];

        PlayerPrefs.SetInt("numberL", numberL);
    }
}
