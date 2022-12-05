using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RecordsUI : MonoBehaviour
{
    
    [SerializeField] private Transform contentScrolView;
    [SerializeField] private PanelRecord prefabRowTable;
    void Start()
    {
        LoadData();
    }

    
    void LoadData()
    {
        string save = PlayerPrefs.GetString("save");
       //print("save " + save)
        string [] users = save.Split('|');
        for(int i = 0; i < users.Length-1; i++)
        {
            PanelRecord currentRow = Instantiate(prefabRowTable, contentScrolView);
            string [] userInfo = users [i].Split(':');
            currentRow.textUserName.text = userInfo[0];
            currentRow.textScore.text = userInfo[1];
        }
        /* void DeleteRecords()
        {
            PlayerPrefs.DeleteKey("save");
        }*/
    }
}
