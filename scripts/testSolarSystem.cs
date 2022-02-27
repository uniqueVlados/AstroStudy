using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class testSolarSystem : MonoBehaviour
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
        "Какого цвета звезда Солнце?",
        "Что является причиной того, что Солнце светит уже миллиарды лет?",
        "Какая планета самая маленькая в Солнечной системе?",
        "По какой причине телескоп Хаббл не может быть использован для наблюдения Меркурия?",
        "Какая планета в Солнечной системе самая горячая? ",
        "Что у Венеры общего с Землей?",
        "Как ученые определили, что Земля состоит из ядра, мантии и коры?",
        "Что из перечисленного является причиной того, что солнечные частицы отклоняются? ",
        "Чем является орбита Луны? ",
        "Что является причиной перепадов температуры на Луне? ",
        "В честь какого Бога названа планета Марс? ",
        "Почему разряженная атмосфера Марса опасна дл космонавтов? ",
        "Как Оле Ремер смог определить скорость света? ",
        "Из чего преимущественно состоят кольца Сатурна? ",
        "Для какого единственного небесного тела в Солнечной системе официально доказано существование воды на поверхности?",
        "Какая планета является самой холодной в Солнечной системе? ",
        "Почему Уран, самая «синяя» планета в Солнечной системе, имеет такой цвет? ",
        "Какая планета была открыта сначала теоретически, а не путем наблюдений? ",
        "Какому спутнику Нептупа принадлежит 99,5 % массы всех 14 оставшихся спутников? ",
        "У какой планеты Солнечной системы самый большой период обращения вокруг Солнца?",
        "Почему изучение Пояса астероидов представляет большой интерес для людей?",
        "Чем являются мелкие яркие зернышки на поверхности фотосферы Солнца? ",
        "Почему на Меркурии, самой близкой к Солнцу планете, может быть температура  -190 градусов по Цельсию? ",
        "Какая планета ярче всех звезд на небосводе? ",
        "На какой планете в Солнечной системе находится самая большая гора? ",
        "Что является причинной предположений ученых о том, что в центре Юпитера могут происходить процессы радиоактивного распада? ",
        "Какое тело в Солнечной системе самое вулканически-активное? ",
        "У какой планеты скорость вращения вокруг своей оси больше скорости обращения вокруг Солнца? ",
        "Что является причиной вращения Урана вокруг Солнца «лежа на боку»?",
        "Как называется единственная карликовая планета в поясе астероидов?"
    };

    string[,] ans = new string[,] {
        {"красного", "желтого", "белого", "оранжевого"},
        {"термоядерные реакции", "тепло соседних звезд", "горячая атмосфера", "гравитационное взаимодействие с Землей"},
        {"Плутон", "Нептун", "Венера", "Меркурий"},
        {"близость к Солнцу", "большое расстояние между телескопом и планетой", "маленькие размеры Меркурия", "слабая линза телескопа Хаблл"},
        {"Земля", "Марс", "Меркурий", "Венера"},
        {"вода в больших количествах", "атмосфера", "период обращения вокруг Солнца", "количество спутников"},
        {"прорыв скважину", "изучая землетрясения", "читая древние манускрипты", "изучая состав почвы"},
        {"Сильная гравитация Земли и Луны", "облака", "магнитное поле", "большая скорость вращения Земли"},
        {"кругом", "эллипсом", "спиралью", "среди перечисленных ответов верных нет"},
        {"разряженная атмосфера", "отдаленность от Солнца", "скорость обращения вокруг Земли", "состав Луны"},
        {"в честь Бога плодородия", "в честь Бога дождя", "в честь Бога войны", "в честь Богини красоты"},
        {"из - за отсутствия кислорода", "из - за наличия в атмосфере метана", "из - за бурь и ураганов", "из - за радиации"},
        {"наблюдая за изменением скорости Юпитера", "наблюдая за периодом обращения Юпитера вокруг своей оси", "наблюдая за спутником Юпитера", "наблюдая за движением Юпитера относительно Земли"},
        {"лед", "аммиак", "углерод", "водород"},
        {"Мимас", "Фобос", "Титан", "Европа"},
        {"Юпитер", "Плутон", "Нептуп", "Уран"},
        {"из - за наличия метана в атмосфере", "из - за очень холодной атмосферы", "из - за наличия аммиака в атмосфере", "из - за наличия молекул воды в атмосфере"},
        {"Плутон", "Нептун", "Уран", "Сатурн"},
        {"Тритон", "Митрон", "Европа", "Демос"},
        {"Уран", "Плутон", "Юпитер", "Нептун"},
        {"из - за размеров Пояса", "из - за недоступности Пояса", "из - за состава Пояса", "из - за близости Пояса к Марса"},
        {"смесью теплых и остывших газов", "кусочками магмы", "неровностями на поверхности Солнца", "темными пятнами"},
        {"из - за отсутствия атмосферы", "из - за медленного вращения", "из - за полярных шапок", "из - за состава коры"},
        {"Меркурий", "Марс", "Сириус", "Венера"},
        {"Земля", "Венера", "Юпитер", "Марс"},
        {"излучение в пространство большого количества энергии", "огромная масса планеты", "большой период вращения планеты", "близость Юпитера к Сатурну"},
        {"Ганимед", "Меркурий", "Ио", "Титан"},
        {"Земля", "Нептун", "Юпитер", "Сатурн"},
        {"столкновение с большим телом", "слабая гравитация вдали от Солнца", "влияние Юпитера и Сатурна", "маленький период вращения вокруг своей оси"},
        {"Титан", "Мимас", "Церера", "Фарон"}
        };

    string[] qtextSolarEn = new string[] {
        "What color is the Sun star? ",
        "What is the reason that the Sun has been shining for billions of years? ?",
        "Which planet is the smallest in the Solar system?  ",
        "why can't the Hubble telescope be used to observe mercury?  ",
        "Which planet in the Solar system is the hottest? ",
        "what does Venus have in common with Earth? ",
        "how did scientists determine that the Earth consists of a core, mantle, and crust? ",
        "Which of the following causes solar particles to be deflected? ",
        "What is the moon's orbit? ",
        "What causes temperature changes on the moon? ",
        "what God is the planet Mars named after? ",
        "Why is the thin atmosphere of Mars dangerous for astronauts? ",
        "how did OLE Roemer determine the speed of light? ",
        "what are the main components of Saturn's rings? ",
        "for which single celestial body in the Solar system is the existence of water on the surface officially proven? ",
        "Which planet is the coldest in the Solar system? ",
        "Why does Uranus, the bluest planet in the Solar system, have such a color? ",
        "Which planet was first discovered theoretically, and not by observation? ",
        "What satellite Natopa owned 99,5 % of the mass of all the remaining 14 satellites? ",
        "which planet in the Solar system has the longest period of rotation around the Sun ",
        "Why is the study of the asteroid Belt of great interest to people? ",
        "What are the small bright grains on the surface of the Sun's photosphere? ",
        "Why can mercury, the planet closest to the Sun, have a temperature of -190 degrees Celsius? ",
        "Which planet is brighter than all the stars in the sky?  ",
        "which planet in the Solar system has the largest mountain? ",
        "what is the cause of scientists assumptions that the center of Jupiter may be the process of radioactive decay?",
        "What is the most volcanically active body in the Solar system?",
        "which planet has a rotation speed around its axis greater than the speed of rotation around the Sun?",
        "What causes Uranus to rotate around the Sun lying on its side? ",
        "What is the name of the only dwarf planet in the asteroid belt? "
    };

    string[,] ansEn = new string[,] {
        {"red", "yellow", "white", "orange"},
        {"thermonuclear reactions", "heat of neighboring stars", "hot atmosphere", "gravitational interaction with the Earth"},
        {"Pluto", "Neptune", "Venus", "Mercury"},
        {"proximity to the Sun", "long distance between the telescope and the planet", "small size of mercury", "weak lens of the Hubble telescope"},
        {"Earth", "Mars", "Mercury", "Venus"},
        {"water in large quantities", "atmosphere", "period of revolution around the Sun", "number of satellites"},
        {"digging a well", "studying earthquakes", "reading ancient manuscripts", "studying the composition of the soil"},
        {"Strong gravity of the Earth and moon", "clouds", "magnetic field", "high speed of rotation of the Earth"},
        {"circle", "ellipse", "spiral", "none of the listed answers are correct"},
        {"rarefied atmosphere", "distance from the Sun", "speed of rotation around the Earth", "composition of the moon"},
        {"in honor of the God of fertility", "in honor of the God of rain", "in honor of the God of war", "in honor of the Goddess of beauty"},
        {"due to the lack of oxygen", "due to the presence of methane in the atmosphere", "due to storms and hurricanes", "due to radiation"},
        {"observing the change in the speed of Jupiter", "observing the period of Jupiters revolution around its axis", "observing the satellite of Jupiter", "observing the movement of Jupiter relative to the Earth"},
        {"ice", "ammonia", "carbon", "hydrogen"},
        {"Mimas", "Phobos", "Titan", "Europa"},
        {"Jupiter", "Pluto", "Neptune", "Uranus"},
        {"due to the presence of methane in the atmosphere", "due to the extremely cold atmosphere due to the presence of ammonia in the atmosphere", "due to the presence of water molecules in the atmosphere", "nothing out of this"},
        {"Pluto", "Neptune", "Uranus", "Saturn"},
        {"Triton", "Mitron", "Europa", "Demos"},
        {"Uranus", "Pluto", "Jupiter", "Neptune"},
        {"because of the size of the Belt", "due to the unavailability of the Belt", "because of the composition of the Belt", "due to the proximity of the Belt to Mars"},
        {"a mixture of warm and cold gases", "pieces of magma", "irregularities on the surface of the Sun", "dark spots"},
        {"because of the lack of atmosphere", "because of the slow rotation", "because of the polar caps", "because of the composition of the crust"},
        {"Mercury", "Mars", "Sirius", "Venus"},
        {"Earth", "Venus", "Jupiter", "Mars"},
        {"radiation into space of a large amount of energy", "the huge mass of the planet", "the long period of rotation of the planet", "the proximity of Jupiter to Saturn"},
        {"Ganymede", "Mercury", "IO", "Titan"},
        {"Earth", "Neptune", "Jupiter", "Saturn"},
        {"collision with a large body", "weak gravity away from the Sun", "the influence of Jupiter and Saturn", "a small period of rotation around its axis"},
        {"Titan", "Mimas", "Ceres", "Pharaun"}
        };

    int[] rightAns = new int[] {3, 1, 4, 1, 4, 2, 2, 3, 3, 1, 3, 4, 3, 1, 3, 1, 2, 1, 4, 3, 1, 2, 4, 4, 1, 3, 4, 1, 3};

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
