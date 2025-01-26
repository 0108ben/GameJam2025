using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level");
    } 

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
