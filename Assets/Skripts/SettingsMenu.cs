/*using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SettingsMenu : MonoBehaviour
{
    
    [SerializeField] private TMP_InputField inputUserName;
    [SerializeField] private TextMeshProUGUI errorText;
    
    public void Save()
    {
       string userName = inputUserName.text;
       if(userName.Length < 4)
       {
        errorText.text = "ERROR: enter username > 3 chars";
        return;
       }
    for (int i = 0; i < userName.Length; i++)
    {
        if(userName [i] == ' ')
        {
            errorText.text = "ERROR: delete space";
            return;
        }
    }
    SingUserData.singletone.userName = userName;
    SceneManager.LoadScene(0);
    }
}*/
    
