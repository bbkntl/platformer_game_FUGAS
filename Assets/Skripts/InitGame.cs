using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    
    void Start()
    {
        Transform player = SingletonPerson.singleton.transform;
        player.position = GameObject.Find("StartPoint").transform.position;
        //Camera.GetComponent<Camera>().InitCam(player);
        
    }
}
    
