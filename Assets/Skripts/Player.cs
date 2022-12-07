using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int health = 3;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private TextMeshProUGUI textCoins;
    [SerializeField] private bool isMobileController = false;
    [SerializeField] private Hearts heart;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform cheakPoint;
   [SerializeField] private Transform sensorGround;
   
   // private bool isGrounded = false;
    private bool isGrounded;
    public float move;
    //private bool isRight = true;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    //private Animator anim:
    public int pointsCount = 0;
    public int weaponCount = 0;

    /*public int CoinsCount
    {
        get => coinsCount;
    }*/
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coins")
        {
            pointsCount += 10;
            textCoins.text = pointsCount.ToString();
            GameObject coins = collision.gameObject;
            Destroy(coins);
        }
        
    }
     private void Return()
   {
    
    if(transform.position.x < cheakPoint.position.x)
    {
       
    transform.position = startPoint.position;
    }
    else if(transform.position.x > cheakPoint.position.x)
    {
        
        transform.position = cheakPoint.position;
    }
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Floor")
        {
            Damage();
             
        }
        else if ( collision.transform.tag == "Hearts")
        {
            Add();
        }
    }
    private void Damage()
    {
        health--;
        heart.RemuveHearts();
        Return();
        //SAvePlayer();
        
        if(health == 0)
        {
            Time.timeScale = 0;
            heart.GameOver();
        }
        
    }
    private void Add()
    {
        health++;
        heart.AddHearts();
       
        
    }
    



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        //anim = GetComponent<Animator>();
        //SceneManager.sceneLoaded += LevelLoaded;
    }
    /*void Stast()
    {
        SetValueInUI();
    }
    void SetValueInUI()
    {
     heart.SetCountWeaponUI(weaponCount);
     heart.SetCountHealthUI(health);
     heart.SetCountCoinsUI(coinsCount);
    }
    void LevelLoaded(Scene scene, LoadSceneMode mode)
    {
        if(SingletonePerson.singletone.transform == transform)
        {
            heart = FindObjectOfType<Hearts>();
            SetValueInUI();
        }
    }*/
    
    private void FixedUpdate()
    {
        //if(isControl)
        
           if(!isMobileController)
            {
                 move = Input.GetAxis("Horizontal");
            }
            rb.velocity = new Vector3(move * speed, rb.velocity.y, 0);
            //anim.SetFloat("speedX", Mathf.Abs(move));
            //Flip(move);
        
        CheckGround();
    }

    private void Update()
    {
       /*if(isControl)
       {
        Jump();

       }*/
        if (Input.GetButton("Horizontal"))
        
            Run();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal"); 
        
        Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
 
 /*private void Jump()
 {
    isGrounded = Physics2D.OverlapCircleAll(sensorGround.position, 0.3f).Length>1;
    if(Input,GetButtonDown("Jump") && isGrounded)
    {
        rb.AddForce(Vector2.up * jump);
    }
    anim.SetFloat("speedY", rb.velocity.y);
    anim.SetBool("isGrounded", isGrounded);
 }*/

 public void JumpMobile()
 {
   isGrounded = Physics2D.OverlapCircleAll(sensorGround.position, 0.3f).Length>1;
    if(isGrounded)
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
   
 }
/* void Flip(float move)
 {
    if(move<0 && isRight)
    {
        isRight = false;
        sr.flipX = true;
    }
 }*/
    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position + Vector3.down, 0.3f);
        isGrounded = collider.Length > 1;
    }


}
