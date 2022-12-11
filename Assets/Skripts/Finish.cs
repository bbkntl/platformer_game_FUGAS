using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.CompareTag("Player"))
    {
        UnLockLevel();
        SceneManager.LoadScene(0);
        
    }
    
   }

   public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if(currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }
   
   
   
    /*[SerializeField] private int idNextLevel;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Player")
        {
            SceneManager.LoadScene(idNextLevel);
        }
        
    }*/
}
