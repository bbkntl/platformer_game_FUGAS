using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{
    [SerializeField] private GameObject[] objHearts;
    [SerializeField] private GameObject panelGameOver;
    private int hearts = 3;
    public void AddHearts()
    {
        hearts++;
        UpdateHearts();
    }
    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }
    
    
    public void RemuveHearts()
    {
        hearts--;
        UpdateHearts();
    }
    void UpdateHearts()
    {
        for(int i =0; i<3; i++)
        {
            if (hearts > i)
            {
                objHearts[i].SetActive(true);
            }
            else
            {
                objHearts[i].SetActive(false);
            }
            }
        }
  
    }




