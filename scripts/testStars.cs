using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class testStars : MonoBehaviour
{
    public TextMeshProUGUI q;
    public TextMeshProUGUI ans1, ans2, ans3, ans4, howAns;

    public Button[] ansButton = new Button[4];
    public Button again;

    public Sprite[] color = new Sprite[3];
    int rAns = 0;
    int wrAns = 0;

    public int num = 0;
    int photo_num = 0;

    public GameObject photo;
    public Sprite[] photos = new Sprite[15];

    string[] qtextSolar = new string[] {
        "Что является главным фактором в спектральной классификации звезд на группы?     ",
        "Из-за чего сжимается облако пыли и газа при начальных этапах формирования звезды? ",
        "От чего зависит срок жизни звезды? ",
        "",
        "Сколько галактик можно разглядеть на небе невооруженным глазом? ",
        "",
        "У переменных звезд меняется?",
        "",
        "Как образуются черные дыры? ",
        "",
        "Где в галактике находится самая большая черная дыра? ",
        "",
        "Что является конечным этапом эволюции звезд средней и малой массы? ",
        "",
        "Во сколько раз должна превышать масса звезды массу Солнца, чтобы стать черной дырой? ",
        "",
        "Какая галактика является самой большой из открытых во Вселенной? ",
        "",
        "В каком созвездии находится Солнце? ",
        "",
        "Какие звезды называют магнетарами? ",
        "",
        "",
        "Почему у черных дыр скорость стремится к скорости света? ",
        "",
        "В окрестностях Солнца около половины звезд являются ",
        "",
        "",
        "",
        ""
    };

    string[,] ans = new string[,] {
        {"температура", "размер", "яркость", "масса"},
        {"из-за внешних сил", "из-за собственной гравитации", "из-за темной материи", "из большой скорости"},
        {"от температуры", "от близости к другим звездам", "от яркости", "от массы"},
        {"рак", "скорпион", "Орион", "Дева"},
        {"1", "2", "3", "4"},
        {"Дева", "Большой Пес", "Ворон", "Дельфин"},
        {"масса", "блеск", "температура", "химический состав"},
        {"Лев", "Андромеда", "Дева", "Малая медведица"},
        {"в результате коллапса гигантских звезды", "в результате расширения красного гиганта", "в результате резкого изменения температуры", "в результате резкого изменения массы"},
        {"Гидра", "Центавр", "Орион", "Волк"},
        {"в гало", "в центре", "на краю галактики", "зависит от галактики"},
        {"Центавр", "Волк", "Лебедь", "Цефей"},
        {"черная дыра", "сверхновая звезда", "красный гигант", "белый карлик"},
        {"Большой Пес", "Малый Пес", "Большая медведица", "Малая медведица"},
        {"2", "3", "10", "100"},
        {"Геракл", "Геркулес", "Орион", "Овен"},
        {"Андромеда", "М 33", "IC 1101", "GSR 349"},
        {"Лев", "Дева", "Дракон", "Близнецы"},
        {"Большая медведица", "Рыбы", "Стрелец", "Близнецы"},
        {"Близнецы", "Дракон", "Пегас", "Орион"},
        {"звезды с огромной массой", "звезды с сильным магнитным полем", "звезды с большой температурой в центре ядра", "звезды большим коэффициентом светимости"},
        {"Малая медведица", "Большая медведица", "Орион", "Геркулес"},
        {"Кассиопея", "Козерог", "Корма", "Гидра"},
        {"чтобы сохранить момент импульса", "чтобы не выпустить свет", "чтобы захватить находящуюся вблизи материю", "чтобы не превратиться обратно в красного гиганта"},
        {"Конь", "Пегас", "Лебедь", "Рыбы"},
        {"двойными звездами", "тройными звездами", "белыми карликами", "красными гигантами"},
        {"большая медведица", "Малая медведица", "Волк", "Овен"},
        {"Орион", "Дева", "Волк", "Цефея"},
        {"Лев", "Геркулес", "Андромеда", "Весы"},
        {"Дева", "Жираф", "Журавль", "Гидра"}
        };

    string[] qtextSolarEn = new string[] {
        "What is the main factor in the spectral classification of stars into groups? ",
        "why is the cloud of dust and gas compressed during the initial stages of star formation? ",
        "What determines the lifetime of a star? ",
        "",
        "How many galaxies can be seen in the sky with the naked eye? ",
        "",
        "variable stars change?",
        "",
        "How do black holes form? ",
        "",
        "Where is the largest black hole in the galaxy? ",
        "",
        "What is the final stage in the evolution of medium-and low-mass stars? ",
        "",
        "how many times must the mass of a star exceed the mass of the Sun to become a black hole?  ",
        "",
        "Which galaxy is the largest discovered in the Universe? ",
        "",
        "in which constellation is the Sun? ",
        "",
        "Which stars are called magnetars? ",
        "",
        "",
        "Why does the speed of black holes tend to the speed of light? ",
        "",
        "in the vicinity of the Sun, about half of the stars are ",
        "",
        "",
        "",
        ""
    };

    string[,] ansEn = new string[,] {
        {"temperature", "size", "brightness", "mass"},
        {"due to external forces", "due to its own gravity", "due to dark matter", "due to high speed"},
        {"from temperature", "from proximity to other stars", "from brightness", "from mass"},
        {"cancer", "Scorpio", "Orion", "Virgo"},
        {"1", "2", "3", "4"},
        {"Virgo", "Big Dog", "Raven", "Dolphin"},
        {"mass", "brightness", "temperature", "chemical composition"},
        {"Leo", "Andromeda", "Virgo", "URSA Minor"},
        {"as a result of the collapse of giant stars", "resulting from the expansion of a red giant", "the result of sudden changes of temperature", "sudden changes in weight"},
        {"Hydra", "Centauri", "Orion", "Wolf"},
        {"in the halo", "in the center", "at the edge of the galaxy", "depends on the galaxy"},
        {"Centaurus", "Wolf", "Swan", "Cepheus"},
        {"black hole", "supernova", "red giant", "white dwarf"},
        {"Big Dog", "Little Dog", "big dipper", "Little dipper"},
        {"2", "3", "10", "100"},
        {"Hercules", "Hercules", "Orion", "Aries"},
        {"Andromeda", "M 33", "IC 1101", "GSR 349"},
        {"Leo", "Virgo", "Dragon", "Gemini"},
        {"URSA major", "Pisces", "Sagittarius", "Gemini"},
        {"Gemini", "Dragon", "Pegasus", "Orion"},
        {"stars with a huge mass", "stars with a strong magnetic field", "stars with a high temperature in the center of the core", "stars with a large luminosity coefficient"},
        {"URSA minor", "URSA Major", "Orion", "Hercules"},
        {"Cassiopeia", "Capricorn", "Korma", "Hydra"},
        {"to preserve the moment of momentum", "not to release light", "to capture nearby matter", "not to turn back into a red giant"},
        {"Horse", "Pegasus", "Swan", "Pisces"},
        {"double stars", "triple stars", "white dwarfs", "red giants"},
        {"big dipper", "little dipper", "the wolf", "the RAM"},
        {"Orion", "Virgo", "Wolf", "Cepheus"},
        {"Leo", "Hercules", "Andromeda", "Libra"},
        {"Virgo", "Giraffe", "Crane", "Hydra"}
        };

    int[] rightAns = new int[] { 1, 2, 4, 1, 4, 1, 2, 1, 1, 2, 2, 4, 4, 1, 2, 2, 3, 3, 2, 1, 2, 2, 1, 1, 2, 1, 2, 1, 3, 4 };

    int numberL;

    void Start()
    {
        numberL = PlayerPrefs.GetInt("numberL");
        if (numberL == 1)
        {
            q.text = qtextSolar[0];
            ans1.text = ans[0, 0];
            ans2.text = ans[0, 1];
            ans3.text = ans[0, 2];
            ans4.text = ans[0, 3];
        }
        else
        {
            q.text = qtextSolarEn[0];
            ans1.text = ansEn[0, 0];
            ans2.text = ansEn[0, 1];
            ans3.text = ansEn[0, 2];
            ans4.text = ansEn[0, 3];
        }
        howAns.text = "1/30";
    }

    public void ans_1()
    {
        if (rightAns[num] == 1)
        {
            rAns += 1;
            ansButton[0].GetComponent<Image>().sprite = color[0];
        }
        else
        {
            wrAns += 1;
            ansButton[0].GetComponent<Image>().sprite = color[1];
            ansButton[rightAns[num] - 1].GetComponent<Image>().sprite = color[0];
        }
        StartCoroutine(pause());
        num += 1;
    }

    public void ans_2()
    {
        if (rightAns[num] == 2)
        {
            rAns += 1;
            ansButton[1].GetComponent<Image>().sprite = color[0];
        }
        else
        {
            wrAns += 1;
            ansButton[1].GetComponent<Image>().sprite = color[1];
            ansButton[rightAns[num] - 1].GetComponent<Image>().sprite = color[0];
        }
        StartCoroutine(pause());
        num += 1;
    }
    public void ans_3()
    {
        if (rightAns[num] == 3)
        {
            rAns += 1;
            Debug.Log(1);
            ansButton[2].GetComponent<Image>().sprite = color[0];
        }
        else
        {
            wrAns += 1;
            ansButton[2].GetComponent<Image>().sprite = color[1];
            ansButton[rightAns[num] - 1].GetComponent<Image>().sprite = color[0];
        }
        StartCoroutine(pause());
        Debug.Log(2);
        num += 1;
    }
    public void ans_4()
    {
        if (rightAns[num] == 4)
        {
            rAns += 1;
            ansButton[3].GetComponent<Image>().sprite = color[0];
        }
        else
        {
            wrAns += 1;
            ansButton[3].GetComponent<Image>().sprite = color[1];
            ansButton[rightAns[num] - 1].GetComponent<Image>().sprite = color[0];
        }
        StartCoroutine(pause());
        num += 1;
    }



    IEnumerator pause()
    {
        yield return new WaitForSecondsRealtime(1f);

        if (
                num + 1 == 4 ||
                num + 1 == 6 ||
                num + 1 == 8 ||
                num + 1 == 10 ||
                num + 1 == 12 ||
                num + 1 == 14 ||
                num + 1 == 16 ||
                num + 1 == 18 ||
                num + 1 == 20 ||
                num + 1 == 22 ||
                num + 1 == 23 ||
                num + 1 == 25 ||
                num + 1 == 27 ||
                num + 1 == 28 ||
                num + 1 == 30)
        {
            photo.SetActive(true);
            photo.GetComponent<Image>().sprite = photos[photo_num];
            photo_num += 1;
        }
        else
        {
            photo.SetActive(false);
        }

        if (numberL == 1)
        {
            if (wrAns < 3)
            {
                for (int i = 0; i < 4; i++)
                    ansButton[i].GetComponent<Image>().sprite = color[2];

                q.text = qtextSolar[num];
                ans1.text = ans[num, 0];
                ans2.text = ans[num, 1];
                ans3.text = ans[num, 2];
                ans4.text = ans[num, 3];
                howAns.text = (num + 1).ToString() + "/30";
            }
            else if (rAns < 30)
            {
                photo.SetActive(false);
                for (int i = 0; i < 4; i++)
                    ansButton[i].gameObject.SetActive(false);
                q.text = "ВЫ ДОПУСТИЛИ 3 ОШИБКИ\nПравильных ответов " + rAns.ToString() + "/30";
                ans1.text = "";
                ans2.text = "";
                ans3.text = "";
                ans4.text = "";
                howAns.text = "";
                again.gameObject.SetActive(true);
            }
            else
            {
   
                for (int i = 0; i < 4; i++)
                    ansButton[i].gameObject.SetActive(false);
                q.text = "ВЫ СПРАВИЛИСЬ\nПравильных ответов " + "30/30\nНАЧАТЬ СНОВА?";
                ans1.text = "";
                ans2.text = "";
                ans3.text = "";
                ans4.text = "";
                howAns.text = "";
                again.gameObject.SetActive(true);
            }
        }
        else
        {
            if (wrAns < 3)
            {
                for (int i = 0; i < 4; i++)
                    ansButton[i].GetComponent<Image>().sprite = color[2];

                q.text = qtextSolarEn[num];
                ans1.text = ansEn[num, 0];
                ans2.text = ansEn[num, 1];
                ans3.text = ansEn[num, 2];
                ans4.text = ansEn[num, 3];
                howAns.text = (num + 1).ToString() + "/30";
            }
            else if (rAns < 30)
            {
                photo.SetActive(false);
                for (int i = 0; i < 4; i++)
                    ansButton[i].gameObject.SetActive(false);
                q.text = "YOU MADE 3 ERRORS\nCorrect answers " + rAns.ToString() + "/30";
                ans1.text = "";
                ans2.text = "";
                ans3.text = "";
                ans4.text = "";
                howAns.text = "";
                again.gameObject.SetActive(true);
            }
            else
            {
                photo.SetActive(false);
                for (int i = 0; i < 4; i++)
                    ansButton[i].gameObject.SetActive(false);
                q.text = "YOU HAVE DONE\nCorrect answers " + "30/30\nSTART AGAIN";
                ans1.text = "";
                ans2.text = "";
                ans3.text = "";
                ans4.text = "";
                howAns.text = "";
                again.gameObject.SetActive(true);
            }
        }
    }
}
