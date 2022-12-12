using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private float speed = 10f;
    private Vector3 dir;
    public Vector3 Direction {set {dir = value;}}
    private SpriteRenderer sprite;

   private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start() 
    {
        Destroy(gameObject, 1.4f);
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
}
