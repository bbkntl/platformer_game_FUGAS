using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Menu : MonoBehaviour
{
 

    public void StartGame()
    {
        SceneManager.LoadScene(4);
    }
    public void Exit()
    {

        Application.Quit();

    }
    public void Levels()
    {
        SceneManager.LoadScene(1);
    }
    public void Levels1()
    {
        SceneManager.LoadScene(4);
    }
    public void Levels2()
    {
        SceneManager.LoadScene(5);
    }
    public void Levels3()
    {
        SceneManager.LoadScene(6);
    }
    public void Levels4()
    {
        SceneManager.LoadScene(7);
    }
    public void Levels5()
    {
        SceneManager.LoadScene(8);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(4);
    }
    public void ExitInMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Records()
    {
        SceneManager.LoadScene(3);
    }
    public void Settings()
    {
        SceneManager.LoadScene(2);
    }
}