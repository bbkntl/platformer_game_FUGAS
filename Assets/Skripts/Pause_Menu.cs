using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
 


    public GameObject panel;
    public void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0.00001f;
    }
    public void ContinueGame()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
    

}
