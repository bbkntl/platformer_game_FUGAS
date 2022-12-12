using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Finish : MonoBehaviour
{
   [SerializeField] private int idNextLevel;
   private void OnTriggerEnter2D(Collider2D collision)
   {
    //if(collision.CompareTag("Player"))
    if(collision.tag == "Player")
    {
        //StartCoroutine(TimerLoadLevel());
        //Player player = collision.GetComponent<Player>();
        //player.SaveData();
        UnLockLevel();
        SceneManager.LoadScene(idNextLevel);
        
    }
   /* IEnumerator TimerLoadLevel()
    {
        yield returt WaitForSeconds(0.5f);
        SceneManager.LoadScene(idNextLevel);
    }*/
    
   }
//[SerializeField] private int idNextLevel;

/*private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Player")
        {
            UnLockLevel();
            SceneManager.LoadScene(idNextLevel);
        }
        
    }*/
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
