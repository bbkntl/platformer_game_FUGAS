using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   
    public Button [] levels;

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
    }

     /*int levelUnLock;
   public Button [] buttons;
    
    void Start()
    {
        levelUnLock = PlayerPrefs.GetInt("levels", 1);
        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
         for(int i = 0; i < levelUnLock; i++)
        {
            buttons[i].interactable = true;
        }
    }

    
    public void loadLevel(int idNextLevel)
    {
        SceneManager.LoadScene(idNextLevel);
    }*/
    
}
