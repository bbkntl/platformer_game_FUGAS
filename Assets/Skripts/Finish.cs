using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    //public int sceneIndex;
    [SerializeField] private int idNextLevel;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(idNextLevel);
        }
    }
}
