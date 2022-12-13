using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Menu : MonoBehaviour
{
 
/*public Button continueButton;
    
     void Start() 
     {
        if(UserDataController.Instance.LastLevel = 0)
        {
            continueButton.interactable = false;
        }
    }*/
    
    public void StartGame()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
        UserDataController.Instance.ResetData();
       
    }
    public void ContinueMainMenu()
    {
        SceneManager.LoadScene(UserDataController.Instance.LastLevel);
        Time.timeScale = 1f;
    }
    
    public void Exit()
    {

        Application.Quit();

    }
    public void Levels()
    {
        SceneManager.LoadScene(1);
         UserDataController.Instance.ResetData();
        
    }
    public void Levels1()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
         UserDataController.Instance.ResetData();
    }
    public void Levels2()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
         UserDataController.Instance.ResetData();
    }
    public void Levels3()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
         UserDataController.Instance.ResetData();
    }
    public void Levels4()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
         UserDataController.Instance.ResetData();
    }
    public void Levels5()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
         UserDataController.Instance.ResetData();
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
         UserDataController.Instance.LastLevel = SceneManager.GetActiveScene().buildIndex;
    }
    public void RestartGame1()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
    public void RestartGame2()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }
    public void RestartGame3()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }
    public void RestartGame4()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }
    public void RestartGame5()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
    public void ExitInMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Records()
    {
        SceneManager.LoadScene(3);
        UserDataController.Instance.ResetData();
    }
    public void Settings()
    {
        SceneManager.LoadScene(2);
    }
}