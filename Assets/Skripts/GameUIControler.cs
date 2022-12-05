using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUIControler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUserName;
[SerializeField] private TextMeshProUGUI textScore;
private int score = 0;
    void Start()
    {
      textUserName.text = SingUserData.singletone.userName;  
    }

   
   
   /*public void AddScore()
    {
        score += Random.Range(1,5);
        textScore.text = "Score: " + score;
    }*/
    public void ReturnMenu()
    {
        string saveScore = PlayerPrefs.GetString("save");
        string [] users = saveScore.Split('|');
        string userName = SingUserData.singletone.userName;
        bool isNewUser = true;
        saveScore = "";
        for(int i = 0; i < users.Length-1; i++)
        {
            string [] userInfo = users[i].Split(':');
            if(userInfo[0] == userName)
            {
                if(score > int.Parse(userInfo[1]))
                {
                    userInfo[1] = score.ToString();
                    
                }
                isNewUser = false;
            }
             saveScore += $"{userInfo[0]}:{userInfo[1]}|";
        }
        if(isNewUser)
        {
            saveScore += $"{userName}:{score}|";
        }
        
        PlayerPrefs.SetString("save", saveScore);
        SceneManager.LoadScene(0);
    }
}
