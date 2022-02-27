using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class testNature : MonoBehaviour
{
    public TextMeshProUGUI q;
    public TextMeshProUGUI ans1, ans2, ans3, ans4, howAns;

    public Button[] ansButton = new Button[4];
    public Button again;

    public Sprite[] color = new Sprite[3];
    int rAns = 0;
    int wrAns = 0;

    public int num = 0;
    string[] qtextSolar = new string[] {
        "Кто первым направил подзорную трубу в небо и провел наблюдения? ",
        "Почему люди отправляют телескопы на орбиту Земли? ",
        "Что принято считать центром отсчета при наблюдении за звездами? ",
        "Почему каталоги со светилами переписываются, если положение звезды принимается за постоянную величину? ",
        "Что является причиной миражей? ",
        "Сколько лунных затмений можно наблюдать в год? ",
        "Что является причиной образования радуги?",
        "От чего зависит ширина и яркость радуги?",
        "От чего зависит размер венцов? ",
        "Что такое гало? ",
        "Почему во время лунного затмения Луна становится красно-оранжевой? ",
        "Какая звезда служила главным ориентиром для моряков?  ",
        "Сколько звезд на небе можно увидеть невооруженным глазом? ",
        "Сколько звезд считают на небе навигационными ориентирами? ",
        "На сколько различаются звездные и солнечные сутки? ",
        "Какова скорость света? ",
        "На какой планете кроме Земли можно видеть полные солнечные затмения?",
        "Солнечная корона, которая видна во время солнечных затмений, представляет какую часть Солнца? ",
        "Что такое фата-моргана?",
        "Что такое узлы лунной орбиты? ",
        "Почему солнечное затмение для земного наблюдателя длится несколько минут? ",
        "Какое расположение Солнца, Земли и Луны во время лунного затмения?",
        "Почему лунные затмения натолкнули Аристотеля на размышления о шарообразности Земли? ",
        "Почему внутренняя часть трубы телескопа окрашивается в черный цвет? ",
        "Почему на темном весеннем небе не видно Млечного Пути? ",
        "Какую форму имеет радуга? ",
        "Что в старину называли «Солнце  с ушами» ? ",
        "Встав к Полярной звезде спиной, с какой стороны будет запад?",
        "Почему Луна повернута к Земле одной и той же стороной? ",
        "Что позволило ученым установить, что за 3 тысячи лет продолжительность суток увеличилась на 0,047 секунды? "
    };

    string[,] ans = new string[,] {
        {"Липперсгей", "Галилей", "Гершиль", "Коперник"},
        {"чтобы сократить расстояние до звезд", "чтобы избежать искажение атмосферы", "чтобы зарядить телескоп солнечной энергией", "чтобы избежать искусственного земного света"},
        {"Большую медведицу", "Сириус", "Солнце", "Землю"},
        {"из-за медленного движения звезд", "из-за неточности данных", "из-за возможных погрешностей", "из-за движения Земли"},
        {"смена фокуса глаза", "удаленность объекта", "искривление траектории лучей света", "резкие потоки воздуха"},
        {"12", "от 2 до 4", "6", "от 7 до 13"},
        {"преломление лучей света", "состав атмосферы", "высота облаков", "температура воздуха"},
        {"от высоты радуги", "от скорости ветра", "от количества солнечного света", "от капель воды"},
        {"от размеров капель воды", "от состава капель", "от количества света", "от количества облаков"},
        {"круговое свечение вокруг Солнца", "вид миража", "рефракция лунного света", "переход солнечных лучей из одной части атмосферы в другую"},
        {"из-за искривления солнечных лучей", "из-за рассеивания солнечных лучей в атмосфере", "из-за смены направления Луны", "из-за слабой лунной атмосферы"},
        {"Полярная", "Альфа Центавра", "Сириус", "Ригель"},
        {"около 1 тысячи", "около 3 тысяч", "около 6 тысяч", "около 8 тысяч"},
        {"10", "26", "35", "73"},
        {"24 часа", "4 минуты", "12 часов", "они равны"},
        {"300 тыс. км/c", "100 тыс. км/c", "150 тыс. км/c", "450 тыс. км/c"},
        {"Венера", "Марс", "Юпитер", "таких планет нет"},
        {"фотосфера", "хромосфера", "корона", "магнитосфера"},
        {"разновидность гало", "разновидность миража", "разновидность радуги", "разновидность солнечной вспышки"},
        {"запутанность в теории о лунной орбите", "места оборота луны", "места смены направления вращения", "точки пересечения орбиты луны с эклиптикой"},
        {"из-за скорости тени", "из-за скорости вращения Земли", "из-за атмосферной циркуляции", "из-за движения Солнца"},
        {"Солнце-Земля-Луна", "Солнце-Луна-Земля", "Земля-Солнце-Луна", "Луна-Солнце-Земля"},
        {"потому что Луна частично отражала Землю", "потому что Земля должна быть подобна Солнцу и Луне", "потому что конус Земли имеет шарообразную форму", "ни одно из утверждений не верно"},
        {"чтобы не было бликов", "чтобы лучше было видно линзы", "чтобы свет нагревал линзы", "чтобы лучше наблюдать темные участки неба"},
        {"потому что «постоянные» звезды ярче", "потому что Земля закрывает Млечный Путь", "потому что Луна закрывает Млечный путь", "потому что Земля наклонена под другим углом"},
        {"полукруг", "эллипс", "круг", "растянутая вширь дуга"},
        {"редкую форму гало", "редкую форму венца", "редкую форму миража", "редкую форму Солнечного затмения"},
        {"сзади", "справа", "слева", "спереди"},
        {"потому что Луна не вращается вокруг своей оси", "потому что период вращения Луны равен периоду вращения Земли", "потому что период вращения Луны равен периоду обращения Луны вокруг Земли", "потому что притяжение Земли и Луны взаимно"},
        {"изучение периода вращения Земли", "изучение китайских рукописей о затмениях", "изучение записей голландских ученых", "изучение вращения Луны по спирали"}
        };

    string[] qtextSolarEn = new string[] {
        "Who was the first to point a telescope at the sky and make observations? ",
        "Why do people send telescopes into Earth orbit?",
        "What is considered to be the center of attention when gazing at the stars? ",
        "Why are catalogs with luminaries rewritten if the position of the star is assumed to be a constant value? ",
        "what causes mirages? ",
        "How many lunar eclipses can be observed per year? ",
        "What is the cause of rainbow formation? ",
        "What determines the width and brightness of the rainbow? ",
        "what determines the size of the crowns? ",
        "what is a halo?  ",
        "Why does the Moon turn red-orange during a lunar Eclipse?",
        "Which star served as the main reference point for sailors? ",
        "How many stars in the sky can you see with the naked eye? ",
        "How many stars are considered navigational landmarks in the sky? ",
        "how much do the stellar and solar days differ? ",
        "What is the speed of light?  ",
        "on what planet other than Earth can you see total solar eclipses? ",
        "the Solar corona, which is visible during solar eclipses, represents which part of the Sun?  ",
        "What is Fata Morgana? ",
        "What are the nodes of the lunar orbit? ",
        "Why does a solar Eclipse last several minutes for an earth observer? ",
        "What is the location of the Sun, Earth, and moon during a lunar Eclipse? ",
        "Why did lunar eclipses prompt Aristotle to think about the earths spherical shape? ",
        "Why does the inside of the telescope tube turn black?",
        "Why is the milky Way not visible in the dark spring sky? ",
        "What is the shape of a rainbow?  ",
        "What was called the Sun with ears in the old days ? ",
        "Standing with your back to the North star, which side will be the West? ",
        "Why is the moon facing the Earth with the Same side?",
        "What allowed scientists to establish that for 3 thousand years the duration of the day increased by 0.047 seconds?  "
    };

    string[,] ansEn = new string[,] {
        {"Lippershey", "Galileo", "Hershel", "Copernicus"},
        {"to shorten the distance to the stars", "to avoid distortion of the atmosphere", "to charge the telescope with solar energy", "to avoid artificial earth light"},
        {"Great bear", "Sirius", "the Sun", "the Earth"},
        {"due to the slow movement of the stars", "due to inaccuracies in the data", "due to possible errors", "due to the movement of the Earth"},
        {"changing the focus of the eye", "the distance of the object", "the curvature of the trajectory of light rays", "sharp air flows"},
        {"12", "2 to 4", "6", "7 to 13"},
        {"refraction of light rays", "atmospheric composition", "cloud height", "air temperature"},
        {"the height of the rainbow", "from wind speed", "the amount of sunlight by water droplets", "nothing"},
        {"from the size of water drops", "from the composition of drops", "from the amount of light", "from the number of clouds"},
        {"circular glow around the Sun", "Mirage view", "refraction of moonlight", "the transition of sunlight from one part of the atmosphere to another"},
        {"due to the curvature of the suns rays", "due to scattering of sunlight in the atmosphere", "due to the change of the direction of the moon", "because of the weak lunar atmosphere"},
        {"Polar", "Alpha Centauri", "Sirius", "Rigel"},
        {"about 1 thousand", "about 3 thousand", "about 6 thousand", "about 8 thousand"},
        {"10", "26", "35", "73"},
        {"24 hours", "4 minutes", "12 hours", "they are equal"},
        {"300 thousand km / s", "100 thousand km/ s", "150 thousand km / s", "200 thousand km / s"},
        {"Venus", "Mars", "Jupiter", "there are no such planets"},
        {"photosphere", "chromosphere", "corona", "magnetosphere"},
        {"a kind of halo", "a kind of Mirage", "a kind of rainbow", "a kind of solar flare"},
        {"entanglement in the theory of the lunar orbit", "places where the moon turns", "places where the direction of rotation changes", "points where the moons orbit intersects with the Ecliptic"},
        {"due to the speed of the shadow", "due to The speed of the earths rotation", "due to atmospheric circulation", "due to the movement of the Sun"},
        {"Sun-Earth-Moon", "Sun-Moon-Earth", "Earth-Sun-Moon", "Moon-Sun-Earth"},
        {"because the Moon partially reflected the Earth", "because the Earth must be like the Sun and the moon", "because The earths cone is spherical", "none of the statements are true"},
        {"so that there is no glare", "so that the lenses can be seen better", "so that the light warms the lenses", "so that you can better observe the dark areas of the sky"},
        {"because the permanent stars are brighter", "because the Earth closes the milky Way", "because the Moon closes the milky way", "because the Earth is tilted at a different angle"},
        {"semicircle", "ellipse", "circle", "extended arc"},
        {"a rare form of halo", "a rare form of a crown", "a rare form of Mirage", "a rare form of Solar Eclipse"},
        {"back", "right", "left", "front"},
        {"because the Moon does not rotate around its axis", "because the rotation period of the moon equal to the period of Earths rotation", "because the rotation period of the moon equal to the orbital period of the moon around the Earth", "because the gravity of the Earth and the moon mutually"},
        {"study of The earths rotation period", "study of Chinese manuscripts about eclipses", "study of records of Dutch scientists", "study of the moons rotation in a spiral"}
        };

    int[] rightAns = new int[] {2, 2, 4, 1, 3, 2, 1, 4, 1, 1, 2, 1, 3, 2, 2, 4, 1, 2, 4, 1, 1, 3, 1, 2, 1, 2, 3, 2};

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
