using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject[] objHearts;
    [SerializeField] private GameObject panelGameOver;
    private int health = 3;
    private int maxHealth = 3;
    public void AddHearts()
    {
        health++;
        UpdateHearts();
        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }
    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }
    
    
    public void RemuveHearts()
    {
        health--;
        UpdateHearts();
    }
    void UpdateHearts()
    {
        for(int i =0; i<3; i++)
        {
            if (health > i)
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




