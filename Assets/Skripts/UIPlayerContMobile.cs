using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerContMobile : MonoBehaviour
{
   private Player player; 
    
    void Start()
    {
        player = SingletonPerson.singleton.GetComponent<Player>();
    }
    public void LeftRunDown()
    {
        player.move = -1;
    }
   public void LeftRunUp()
    {
        player.move = 0;
    }
    public void RightRunDown()
    {
        player.move = 1;
    }
    public void RightRunUp()
    {
        player.move = 0;
    }
    public void JumpClick()
    {
        player.JumpMobile();
    }
}
