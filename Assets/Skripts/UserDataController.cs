using System;
using UnityEngine;


[Serializable]
public class UserData
{
    public int Coins;
    public int Arrows;
    public int Health;
    
}

public class UserDataController : MonoBehaviour
{
    public static UserDataController Instance { get; private set; }

    public UserData userData;

    private string PATH => Application.persistentDataPath + "/UserData.txt";

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            print("Create instance");

            LoadData();
        }
        else
        {
            print("Instance was created, delete current");
            Destroy(gameObject);
        }
    }

    private void LoadData()
    {
        if (System.IO.File.Exists(PATH))
        {
            print("load exists user data");
            string json = System.IO.File.ReadAllText(PATH);
            userData = JsonUtility.FromJson<UserData>(json);
        }
        else
        {
            print("create new user data");
            userData = new UserData();
            userData.Coins = 0;
            userData.Arrows = 0;
           
            userData.Health = 3;
        }
    }

    public void SaveData()
    {
        string json = JsonUtility.ToJson(userData);
        System.IO.File.WriteAllText(PATH, json);
        print(json);
    }

    public void AddHealth(int hp)
    {
        userData.Health += hp;
        SaveData();
    }

    public void RemoveHealth(int hp)
    {
        userData.Health -= hp;
        SaveData();
    }

    public void RemoveArrows(int removeArrows)
    {
        userData.Arrows -= removeArrows;
        SaveData();
    }

    public void AddCoins(int coins)
    {
        userData.Coins += coins;
        SaveData();
    }

    /*public void AddCrystals(int amount)
    {
        userData.Crystals += amount;
        SaveData();
    }*/

    public void AddArrows(int amount)
    {
        userData.Arrows += amount;
        SaveData();
    }

    public void ResetData()
    {
        userData.Coins = 0;
        
        userData.Arrows = 0;
        userData.Health = 3;
    }

    public void ResetCoins()
    {
        userData.Coins = 0;
    }

    
    public void ResetArrows()
    {
        userData.Arrows = 0;
    }

    public void ResetHealth()
    {
        userData.Health = 3;
    }

}