using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
   public string Mercury;
   public string Venus;
   public string Earth;
   public string Moon;
   public string Mars;
   public string Main;

    public void LoadMercury()
    {
        SceneManager.LoadScene(Mercury);
    }

    public void LoadVenus()
    {
        SceneManager.LoadScene(Venus);
    }

    public void LoadEarth()
    {
        SceneManager.LoadScene(Earth);
    }

    public void LoadMoon()
    {
        SceneManager.LoadScene(Moon);
    }

    public void LoadMars()
    {
        SceneManager.LoadScene(Mars);
    }

    public void LoadMain()
    {
        SceneManager.LoadScene(Main);
    }
}
