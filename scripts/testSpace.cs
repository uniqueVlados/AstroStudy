using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class testSpace : MonoBehaviour
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
        "Какой элемент является самым распространенным во Вселенной? ",
        "Самыми яркими объектами во Вселенной являются?",
        "Какой параметр квазаров принимается учеными и исследователями за постоянную единицу? ",
        "Как называется уплотненный центр галактики? ",
        "Доказательством какой теории является реликтовое излучение? ",
        "Гравитационными линзами называют объекты, которые ? ",
        "Частицы какого излучения не могут проникнуть через лист бумаги? ",
        "Какое событие из перечисленных является самым ярким событием во Вселенной? ",
        "Как ученые обнаружили темную материю и темную энергию?  ",
        "Какой процент составляет масса всех звезд и галактик во Вселенной? ",
        "Из-за чего на Земле трудно изучить темную материю? ",
        "Какой процент составляет масса темной энергии во Вселенной?  ",
        "Как ученые определили, что Вселенная расширяется? ",
        "Что изучает наука астрономия ?  ",
        "Что заставляет туманности светиться? ",
        "От чего зависит цвет туманности? ",
        "Сколько звезд содержит в себе Млечный Путь? ",
        "Какое излучение возникает при термоядерных реакциях в звездах?",
        "Какое из перечисленных явлений является следствием скопления межзвездной пыли? ",
        "Что может остановить бета излучение?  ",
        "Кого из перечисленных в астрономии называют маяками Вселенной? ",
        "Какой части нашей галактики принадлежит 85% всех светил?",
        "В нашей галактике большая часть соседей Солнца являются? ",
        "Что славяне называли Мамаевой дорогой?",
        "Какая гравитационная линза является самой сильной? ",
        "Что из перечисленных является причиной формирования звезд? ",
        "Какая планета/спутник был(а) первой среди кандидатов на наличие жизни? ",
        "Вместе с какой галактикой наша галактика (Млечный Путь) образует Сверхскопление Девы?",
        "К какому скоплению относится Млечный Путь и вся группа местных галактик? ",
        "Каков диаметр Млечного Пути в световых годах? "
    };

    string[,] ans = new string[,] {
        {"гелий", "водород", "азот", "кислород"},
        {"квазары", "красные гиганты", "черные дыры", "сверхновая звезда"},
        {"светимость", "масса", "яркость", "положение в пространстве"},
        {"гало", "толстый диск", "тонкий диск", "балдж"},
        {"теории Большого Взрыва", "теории о существовании черных дыр", "теории о межзвездном взаимодействии", "теории о постоянстве скорости света"},
        {"своей гравитацией захватывают свет", "притягивают черные дыры", "искривляют пространство", "засасывают кометы и астероиды"},
        {"альфа", "гамма", "бета", "нейтронного излучения"},
        {"рождение сверхновой звезды", "гамма всплески", "выбросы энергии красным гигантом", "формирование черной дыры"},
        {"наблюдая за испускаемым светом", "наблюдая за изменением температуры", "наблюдая за черными дырами", "наблюдая за поведением галактик"},
        {"95%", "67%",  "27%",  "5%"},
        {"из-за ее отдаленности", "из-за ее температуры", "из-за ее редкости в окрестностях  Земли", "из-за отсутствия специальных инструментов"},
        {"70%", "27%", "95%", "39%"},
        {"наблюдая за далекими галактиками", "наблюдая за черными дырами", "наблюдая за светом квазаров", "наблюдая за изменением скорости света"},
        {"планеты", "небесные тела", "звезды", "Землю и её характеристики"},
        {"звезды внутри туманностей", "высокая скорость пыли и газа",  "ультрафиолетовое излучение", "высокая температура близлежащих черных дыр"},
        {"от близости к звезде", "от температуры", "от формы и плотности", "от количества получаемой энергии"},
        {"200-400 млрд", "500-1000 млрд", "10-15 млн", "50-100 млн"},
        {"альфа излучение", "бета излучение", "гамма излучение", "нейтронное излучение"},
        {"зодиакальный свет", "гало", "радуга", "мираж"},
        {"бумага", "метал", "дерево", "атмосфера"},
        {"красные гиганты", "переменные звезды", "квазары", "черные дыры"},
        {"балдж", "окраина галактики", "толстый диск", "тонкий диск"},
        {"красными карликами", "белыми карликами", "красным гигантами", "нейтронными звездами"},
        {"комету Галлея", "Млечный Путь", "Большую Медведицу", "траекторию движения Венеры"},
        {"квазар", "нейтронная звезда", "черная дыра", "темная материя"},
        {"остывание красных гигантов", "гамма-всплески", "черные дыры", "межзвездная пыль"},
        {"Марс", "Европа", "Венера", "Kepler-186f"},
        {"MR31", "Андромеда", "M104", "нет верного ответа из перечисленных"},
        {"Скопление Гидры-Центавры", "Скопление Парусов", "Скопление Девы", "Скопление Ориона"},
        {"50 млн", "100 млн", "200 млн", "500 млн"}
        };



    string[] qtextSolarEn = new string[] {
        "Which element is the most common in the Universe",
        "the brightest objects in the Universe are ?",
        "What parameter of quasars is accepted by scientists and researchers as a constant unit? ",
        "What is the name of the condensed center of the galaxy? ",
        "What is the proof of the theory of relic radiation? ",
        "Gravitational lenses are objects that ? ",
        "what kind of radiation Particles can't penetrate a sheet of paper?",
        "Which of the following events is the brightest event in the Universe? ",
        "How did scientists discover dark matter and dark energy? ",
        "what percentage is the mass of all stars and galaxies in the Universe? ",
        "why is it difficult to study dark matter on Earth? ",
        "What percentage is the mass of dark energy in the Universe? ",
        "How did scientists determine that the universe is expanding?",
        "What does the science of astronomy study ?",
        "What makes nebulae glow?",
        "What does the color of the nebula depend on?  ",
        "How many stars does the milky Way contain? ",
        "What kind of radiation occurs during thermonuclear reactions in stars? ",
        "Which of the above phenomena is a consequence of the accumulation of interstellar dust?",
        "What can stop beta radiation ",
        "Which of those listed in astronomy are called the beacons of the Universe?",
        "Which part of our galaxy belongs to 85% of all the stars? ",
        "in our galaxy, most of the Sun's neighbors are",
        "what did the Slavs call Mamayev road? ",
        "Which gravitational lens is the strongest?  ",
        "Which of the following causes the formation of stars? ",
        "Which planet / satellite was the first candidate for life? ",
        "Together with which galaxy our galaxy (the milky Way) forms?",
        "which cluster does the milky Way and the entire group of local galaxies belong to?  ",
        "what is the diameter of the milky Way in light years? "
    };

    string[,] ansEn = new string[,] {
        {"helium", "hydrogen", "nitrogen", "oxygen"},
        {"quasars", "red giants", "black holes", "supernova"},
        {"luminosity", "mass", "brightness", "position in space"},
        {"halo", "thick disk", "thin disk", "bulge"},
        {"the Big Bang theory", "the theory of black holes", "the theory of interstellar interaction", "the theory of the constancy of the speed of light"},
        {"by their gravity capture light", "attract black holes", "bend space", "and suck in comets and asteroids"},
        {"alpha", "gamma", "beta", "neutron radiation"},
        {"the birth of a supernova", "gamma ray bursts", "the emission energy of the red giant", "forming a black hole"},
        {"observing the light emitted", "observing the temperature change", "observing black holes", "observing the behavior of galaxies"},
        {"95%", "67%",  "27%",  "5%"},
        {"because of its remoteness", "because of its temperature", "because of its rarity in the vicinity of the Earth", "because of the lack of special tools"},
        {"70%", "27%", "95%", "39%"},
        {"watching distant galaxies", "watching black holes", "watching the light of quasars", "watching the speed of light change"},
        {"planets", "the heavenly bodies", "the stars", "the Earth and its charcteristic"},
        {"stars inside nebulae", "high velocity dust and gas", "ultraviolet radiation", "high temperature of nearby black holes"},
        {"from the proximity to the star", "from the temperature", "from the shape and density", "from the amount of energy received"},
        {"200-400 billion", "500-1000 billion", "10 million to 15 million", "50-100 million"},
        {"alpha radiation", "beta radiation", "gamma radiation", "neutron radiation"},
        {"the zodiacal light", "halo", "rainbow", "Mirage"},
        {"paper", "metal", "wood", "atmosphere"},
        {"red giants", "variable stars", "quasars", "black holes"},
        {"bulge", "edge of the galaxy", "thick disk", "thin disk"},
        {"red dwarfs", "white dwarfs", "red giants", "neutron stars"},
        {"Halley's comet", "the milky Way", "URSA Major", "the trajectory of Venus"},
        {"quasar", "neutron star", "black hole", "dark matter"},
        {"cooling of red giants", "gamma-ray bursts", "black holes", "interstellar dust"},
        {"Mars", "Europa", "Venus", "Kepler-186f"},
        {"MR31", "Andromeda", "M104", "there is no correct answer from the above"},
        {"Accumulation Of The Hydra-Centauri", "A Cluster Of Sails", "Cluster Virgo", "Cluster Of Orion"},
        {"50 million", "100 million", "200 million", "500 million"}
        };

    int[] rightAns = new int[] {2, 1, 4, 4, 1, 3, 1, 2, 4, 4, 3, 1, 1, 3, 4, 1, 3, 1, 2, 3, 4, 1, 2, 3, 4, 2, 3, 2};

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
