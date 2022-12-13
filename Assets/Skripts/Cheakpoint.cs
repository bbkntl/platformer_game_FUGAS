using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheakpoint : MonoBehaviour
{
   [SerializeField] private Transform cheakPoint;
    private void OnTriggerEnter2D(Collider2D collision)
   {
    
    if(collision.tag == "Player")
    {
        
        collision.transform.position = cheakPoint.position;
    }
   }
/*private void OnTriggerEnter2D(Collider2D collision)
   {
    
    if(collision.tag == "Player")
    {
        
        collision.GetComponent<Player>().cheakPoint = transform.position;
    }
   }*/

}
