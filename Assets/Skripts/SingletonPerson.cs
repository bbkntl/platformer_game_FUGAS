using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPerson : MonoBehaviour
{
    
    private static SingletonPerson _singletone;
    public static SingletonPerson singleton
    {
        get
        {
            if(_singletone == null)
            {
                _singletone = GameObject.FindObjectOfType<SingletonPerson>();
                DontDestroyOnLoad(_singletone.gameObject);
            }
            return _singletone;
        }
    }
    
    void Awake()
    {
        if(_singletone  == null)
        {
            _singletone = this;
            DontDestroyOnLoad(_singletone.gameObject);
        }
        else if (this != _singletone)
        {
            Destroy(this.gameObject);
        }
    }
}
    
    
