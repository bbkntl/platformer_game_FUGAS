using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject[] objHearts;
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private TextMeshProUGUI textCoins;
    [SerializeField] private TextMeshProUGUI textArrows;
    
   
   
    //public int health = 3;
    /*private int maxHealth = 3;
    public void AddHearts()
    {
        health++;
        UpdateHearts();
        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }*/
    
     private void Start()
    {
        UserData data = UserDataController.Instance.userData;
        UpdateHearts(data.Health);
        textCoins.text = data.Coins.ToString();
        
        textArrows.text = data.Arrows.ToString();
    }
    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }

    public void SetCountCoinsUI(int countCoins)
    {
      textCoins.text = countCoins.ToString();
    }
     public void SetCountArrowsUI(int countArrows)
    {
      textArrows.text = countArrows.ToString();
    }
    /*public void SetCountHealthUI(int countHealth)
    {
      health = countHealth;
      UpdateHearts();
      textArrow.text = countArrow.ToString();
    }*/
    
    /*public void RemuveHearts()
    {
        health--;
        UpdateHearts();
    }*/
    public void UpdateHearts(int health)
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




