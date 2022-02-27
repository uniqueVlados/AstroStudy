using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public class textWaste : MonoBehaviour
{
    public TextMeshProUGUI text;
    int numberL;
    TextAsset myText;

    void Start()
    {
        numberL = PlayerPrefs.GetInt("numberL", 0);

        if (SceneManager.GetActiveScene().name == "solarSystem")
        {
            if (numberL == 0)
                myText = (TextAsset)Resources.Load("solarSystem_en");
            else
                myText = (TextAsset)Resources.Load("solarSystem");
            text.text = myText.text;
        }


        else if (SceneManager.GetActiveScene().name == "stars")
        {
            if (numberL == 0)
                myText = (TextAsset)Resources.Load("stars_en");
            else
                myText = (TextAsset)Resources.Load("stars");
            text.text = myText.text;
        }

        else if (SceneManager.GetActiveScene().name == "space")
        {
            if (numberL == 0)
                myText = (TextAsset)Resources.Load("space_en");
            else
                myText = (TextAsset)Resources.Load("space");
            text.text = myText.text;
        }


        else if (SceneManager.GetActiveScene().name == "nature")
        {
            if (numberL == 0)
                myText = (TextAsset)Resources.Load("nature_en");
            else
                myText = (TextAsset)Resources.Load("nature");
            text.text = myText.text;
        }


        else if (SceneManager.GetActiveScene().name == "inventors")
        {
            if (numberL == 0)
                myText = (TextAsset)Resources.Load("inventors_en");
            else
                myText = (TextAsset)Resources.Load("inventors");
            text.text = myText.text;
        }

    }
}
