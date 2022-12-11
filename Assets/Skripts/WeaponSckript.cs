using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponSckript : MonoBehaviour
{
     [SerializeField] private TextMeshProUGUI textWeapon;
      public int weaponCount = 0;
     
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Weapon")
        {
            weaponCount += 1;
            textWeapon.text = weaponCount.ToString();
            GameObject weapon = collision.gameObject;
            Destroy(weapon);
        }
      
        
    }
}
