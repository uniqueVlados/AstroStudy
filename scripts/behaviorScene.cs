using UnityEngine;
using UnityEngine.SceneManagement;

public class behaviorScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
        {
            if (SceneManager.GetActiveScene().name == "solarSystem" ||
                SceneManager.GetActiveScene().name == "stars" || 
                SceneManager.GetActiveScene().name == "space" ||
                SceneManager.GetActiveScene().name == "nature" ||
                SceneManager.GetActiveScene().name == "inventors")
                    SceneManager.LoadScene("learn");
            else if (SceneManager.GetActiveScene().name == "setting" ||
                SceneManager.GetActiveScene().name == "test" ||
                SceneManager.GetActiveScene().name == "support" ||
                SceneManager.GetActiveScene().name == "learn")
                    SceneManager.LoadScene("start");
        }
    }

    public void learnScene()
    {
        SceneManager.LoadScene("learn");
    }

    public void startScene()
    {
        SceneManager.LoadScene("start");
    }

    public void solarSystem()
    {
        SceneManager.LoadScene("solarSystem");
    }

    public void stars()
    {
        SceneManager.LoadScene("stars");
    }

    public void space()
    {
        SceneManager.LoadScene("space");
    }

    public void nature()
    {
        SceneManager.LoadScene("nature");
    }

    public void inventors()
    {
        SceneManager.LoadScene("inventors");
    }

    public void SendMail()
    {
        Application.OpenURL("mailto:vladbatsaev@mail.ru");
    }

    public void support()
    {
        SceneManager.LoadScene("support");
    }

    public void setting()
    {
        SceneManager.LoadScene("setting");
    }

    public void test()
    {
        SceneManager.LoadScene("test");
    }

    public void solarSystemTest()
    {
        SceneManager.LoadScene("solarSystemTest");
    }

    public void spaceTest()
    {
        SceneManager.LoadScene("spaceTest");
    }

    public void starsTest()
    {
        SceneManager.LoadScene("starsTest");
    }

    public void natureTest()
    {
        SceneManager.LoadScene("natureTest");
    }
}
