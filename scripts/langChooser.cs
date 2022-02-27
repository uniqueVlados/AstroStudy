using UnityEngine;
using TMPro;

public class langChooser : MonoBehaviour
{
    public string textEnglish, textRussia;

    private TextMeshProUGUI textField;


    int numberL;

    private void Awake()
    {
        numberL = PlayerPrefs.GetInt("numberL");
        textField = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        if (numberL == 0)
        {
            textField.text = textEnglish;
        }
        else 
        {
            textField.text = textRussia;
        }
    }

    private void Update() 
    {
        numberL = PlayerPrefs.GetInt("numberL"); // ДЛЯ ОБНОВЛЕНИЯ В РЕАЛЬНОМ ВРЕМЕНИ ТЕКСТА (БОЛЕЕ ОПТИМИЗИРОВАННОЕ РЕШЕНИЕ НЕ НАШЁЛ)

        if (numberL == 0)
        {
            textField.text = textEnglish;
        }
        else 
        {
            textField.text = textRussia;
        }
    }

}
