using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLewer : MonoBehaviour
{

   [SerializeField] private Transform startPoint;
   [SerializeField] private Transform cheakPoint;
   
  
   private void OnTriggerEnter2D(Collider2D collision)
   {
    
    if(transform.position.x < cheakPoint.position.x)
    {
        
        collision.transform.position = startPoint.position;
    }
    else if(transform.position.x > cheakPoint.position.x)
    {
        
        collision.transform.position = cheakPoint.position;
    }
    

   }
}
