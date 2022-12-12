
using UnityEngine;

public class Obstacle : MonoBehaviour
{
     int hp = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Arrow")
        {
            hp--;
            if (hp<= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
