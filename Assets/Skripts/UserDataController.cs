/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class UserData
{
public int Coins;
public int Weapon;
public int Hearts;
}
public class UserDataController : MonoBehaviour
{
    public static UserDataController Instance{get; private set;}
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
        if(System.IO.File.Exists(PATH))
        {
            print("load exists user data");
            string json = System.IO.File.ReadAllText(PATH);
            UserData = JsonUtility.FromJson<UserData>(json);
        }
        else
        {
         print("create new user data");
         UserData = new UserData();
         UserData.Coins = 0;
         UserData.Weapon = 0;
         UserData.Hearts = 3;

        }
    }
    private void SaveData()
    {
       string json = JsonUtility.ToJson(UserData);
       System.IO.File.WriteAllText(PATH, json);
       print(json);

    }
    public void AddHearts(int hearts)
    {
        UserData.Hearts += hearts;
        SaveData();
    }
    public void AddCoins(int coins)
    {
        UserData.Coins += coins;
        SaveData();
    }
public void AddWeapon(int weapon)
    {
        UserData.Weapon += weapon;
        SaveData();
    }
    public void ResetData()
    {
        UserData = new UserData();
        UserData.Coins = 0;
         UserData.Weapon = 0;
         UserData.Hearts = 3;
         SaveData();
    }
}*/
