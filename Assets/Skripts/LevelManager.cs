/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   
    int levelUnlock;
    public Button[] buttons;
    private void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("levels", 1);
        for (int i= 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelUnlock; i++)
        {
            buttons[i].interactable=true;

        }
    }
    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    
    public void Menu()
    {
        UserDataController.Instance.ResetData();
        SceneManager.LoadScene("StartMenu");

    }
    public void StartLevel1()
    {
        UserDataController.Instance.ResetData();
        SceneManager.LoadScene("Level1");
    }
    public void StartLevel2()
    {
        UserDataController.Instance.ResetData();
        SceneManager.LoadScene("Level2");
    }
    public void StartLevel3()
    {
        UserDataController.Instance.ResetData();
        SceneManager.LoadScene("Level3");
    }
    public void StartLevel4()
    {
        UserDataController.Instance.ResetData();
        SceneManager.LoadScene("Level4");
    }
    public void StartLevel5()
    {
        UserDataController.Instance.ResetData();
        SceneManager.LoadScene("Level5");
    }
}*/
    
    /*public Button [] levels;

    private void Start() 
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for(int i = 0; i < levels.Length; i++)
        {
            if(i + 1 > levelReached)
            levels[i].interactable = false;
        }
    }

    public void Select(int numberInBuild)
    {
        SceneManager.LoadScene(numberInBuild);
    }*/

     /*int levelUnLock;
    public Button[] buttons;
    private void Start()
    {
        levelUnLock = PlayerPrefs.GetInt("levels", 1);
        for (int i= 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelUnLock; i++)
        {
            buttons[i].interactable =true;

        }
    }
    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }*/
//}
