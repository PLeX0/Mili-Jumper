using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Timers;

public class Scenes : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(sceneName: "Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene(sceneName: "Menu");
    }

    public void Options()
    {
        SceneManager.LoadScene(sceneName: "Options");
    }

    public void Shop()
    {
        SceneManager.LoadScene(sceneName: "Shop");
    }
}
