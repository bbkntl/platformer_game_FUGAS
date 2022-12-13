using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;


public class Player : MonoBehaviour
{
    const int ForceArrow= 400;
    [SerializeField] private float speed = 3f;
    [SerializeField] private int health = 3;
    //[SerializeField] private GameObject[] objHearts;
    [SerializeField] private float jumpForce = 15f;
   // [SerializeField] private TextMeshProUGUI textCoins;
    //[SerializeField] private bool isMobileController = false;
    [SerializeField] private GameUI gameUI;
    [SerializeField] private Rigidbody2D arrow;
    //[SerializeField] private Rigidbody2D AddForce;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform cheakPoint;
     [SerializeField] private UserDataController userDataController;

    //[SerializeField] private Transform sensorGround;
     //[SerializeField] private Transform transChild;
   
   private bool isGrounded = false;
    //private bool isGrounded;
    public float move;
    private bool isRight = true;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    public int coinsCount = 0;
    public int weaponCount = 0;
    public int healthCount = 3;
    private int arrowCount = 0;
   // public Vector3 cheakPoint;
    //public static Player Instance {get; set;}
    //private Bullet bullet;
    /*public int CoinsCount
    {
        get => coinsCount;
    }*/
    
    

public int coins
{
    get => UserDataController.Instance.userData.Coins;
}
public int arrows
{
    get => UserDataController.Instance.userData.Arrows;
}

    
    private States State
    {
        get {return (States)anim.GetInteger("state");}
        set {anim.SetInteger("state", (int)value);}
    }

    private void Awake()
    {
      
       
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponent<Animator>();
       // bullet = Prefab.Load<Bullet>("Bullet");
        //SceneManager.sceneLoaded += LevelLoaded;
    }
    void Start() 
   {
    //cheakPoint = transform.position;
    //gameUI.SetCountArrowUI(arrowCount);
    //LoadData();
   }
    /*void LoadData()
    {
      if(PlayerPrefs.HasKey("PlayerHealth"))
      {
        coinsCount = PlayerPrefs.GetInt("PlayerCoins");
        gameUI.SetCountCoinsUI(coinsCount);

        health = PlayerPrefs.GetInt("PlayerHealth");
        gameUI.SetCountHealthUI(health);
        
        arrowCount = PlayerPrefs.GetInt("PlayerArrow");
        gameUI.SetCountArrowUI(arrowCount);
      }
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("PlayerCoins", coinsCount);
        PlayerPrefs.SetInt("PlayerHealth", health);
        PlayerPrefs.SetInt("PlayerArrow", arrowCount);
        PlayerPrefs.Save();
    }*/
   
    /*void Stast()
    {
        SetValueInUI();
    }
    void SetValueInUI()
    {
     //print($"{weaponCount} {health} {coinsCount}");
     heart.SetCountWeaponUI(weaponCount);
     heart.SetCountHealthUI(health);
     heart.SetCountCoinsUI(coinsCount);
    }
    void LevelLoaded(Scene scene, LoadSceneMode mode)
    {
        //print("id");
        if(SingletonePerson.singletone.transform == transform)
        {
            heart = FindObjectOfType<Hearts>();
            SetValueInUI();
        }
    }*/
    
    private void FixedUpdate()
    {
        //if(isControl)
        
          /* if(!isMobileController)
            {
                 move = Input.GetAxis("Horizontal");
            }*/
            rb.velocity = new Vector3(move * speed, rb.velocity.y, 0);
            anim.SetFloat("speedX", Mathf.Abs(move));
            Flip(move);
        
        CheckGround();
    }

     void Update()
    {
       /*if(isControl)
       {
        Jump();

       }*/
      
     // if(Time.timeScale >=1)
       
       if (isGrounded) State = States.idle;
       
        //if (Input.GetButton("Fire1")) Shoot();
        if (Input.GetButton("Horizontal")) Run();
        if (isGrounded && Input.GetButtonDown("Jump")) Jump();
       Attack();
    }
     
     /* private void OnApplicationQuit() 
      {
        PlayerPrefs.DeleteAll();
      }*/
        
      
     
     private void Attack()
     {
        //if(Input.GetKeyDown(KeyCode.Return)&& arrowCount >0)
        if(Input.GetKeyDown(KeyCode.Return)&& UserDataController.Instance.userData.Arrows >0)
        {
            UserDataController.Instance.RemoveArrows(1);
            gameUI.SetCountArrowsUI(UserDataController.Instance.userData.Arrows);
            anim.SetTrigger("Attack");
            /*arrowCount --;
            gameUI.SetCountArrowUI(arrowCount);*/
             Rigidbody2D tempArrow = Instantiate(arrow, transform.position, Quaternion.identity);
            tempArrow.AddForce(new Vector2(isRight ? ForceArrow : -ForceArrow, 0 ));
            if(!isRight)
            {
                SpriteRenderer srArrow = tempArrow.GetComponentsInChildren<SpriteRenderer>()[1];
                srArrow.flipX = false;
                //srArrow.flipY = true;

            }
        }

     }
   
    private void Run()
    {
        if (isGrounded) State = States.run;

        Vector3 dir = transform.right * Input.GetAxis("Horizontal"); 
        
       // Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
 /*private void Attack()
 {
    Vector3 position = transform.position;
    position.y +=0.8f;
    Bullet newBullet =Instantiate(bullet, position, transform.rotation) as Bullet;
    newBullet.Direction = newBullet.transform.right * (sprite.flipX ? -1f : 1f);
 }*/

/*private void Jump()
 {
    //isGrounded = Physics2D.OverlapCircleAll(sensorGround.position, 0.3f).Length>1;
     isGrounded = Physics2D.OverlapCircleAll(transform.position + Vector3.down, 0.3f).Length>1;
    if(Input.GetButtonDown("Jump") && isGrounded)
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
    anim.SetFloat("speedY", rb.velocity.y);
    anim.SetBool("isGrounded", isGrounded);
 }*/

 /*public void JumpMobile()
 {
   isGrounded = Physics2D.OverlapCircleAll(transform.position + Vector3.down, 0.3f).Length>1;
    if(isGrounded)
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
   
 }*/
 void Flip(float move)
 {
    if(move<0 && isRight)
    {
        isRight = false;
        //transChild.localScale = new Vector3(-1, 1, 1);
        
        sprite.flipX = true;
    }
    else if(move > 0 && !isRight)
    {
        isRight = true;
        //transChild.localScale = new Vector3(1, 1, 1);
    }sprite.flipX = false;
 }
    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position + Vector3.down, 0.3f);
        isGrounded = collider.Length > 1;
        if (!isGrounded) State = States.jump;
    }

    /*public override void GetDamage()
    {
        health -= 1;
        Debug.Log(health);
    }*/

 private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coins")
        {
            /*coinsCount += 10;
            gameUI.SetCountCoinsUI(coinsCount);
           // textCoins.text = coinsCount.ToString();
            GameObject coins = collision.gameObject;
            Destroy(coins);*/
             UserDataController.Instance.AddCoins (10);
            gameUI.SetCountCoinsUI(UserDataController.Instance.userData.Coins);
            Destroy(collision.gameObject);
        }
       else if(collision.tag == "Arrow")
       {
        //int count = collision.GetComponent<Item>().count;
       // arrowCount += count;
        /*arrowCount += 3;
        gameUI.SetCountArrowUI(arrowCount);
        Destroy(collision.gameObject);*/
        UserDataController.Instance.AddArrows(2);
            gameUI.SetCountArrowsUI(UserDataController.Instance.userData.Arrows);
            Destroy(collision.gameObject);
       }
       /*else if(collision.tag == "Hearts")
       {
            healthCount += 1;
            
            GameObject health = collision.gameObject;
            Destroy(health);
       }*/
      
        
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
        /*else if ( collision.transform.tag == "Hearts")
        {
            Add();
        }*/
        else  if (collision.transform.tag == "Obstacle")
        {
            Damage();
        }
    }
    private void Damage()
    {
        //health--;
        //gameUI.RemuveHearts();
        Return();
        //SAvePlayer();
        
        /*if(health == 0)
        {
            Time.timeScale = 0.00001f ;
            gameUI.GameOver();
        }*/
       UserDataController.Instance.RemoveHealth(1);
        gameUI.UpdateHearts(UserDataController.Instance.userData.Health);
        if (UserDataController.Instance.userData.Health == 0)
        {
            Time.timeScale = 0;
            UserDataController.Instance.ResetHealth();
            gameUI.GameOver();
        }
        
    }
    /*private void Add()
    {
        health++;
        gameUI.AddHearts();
       
        
    }*/
}

public enum States 
{
    idle,
    run,
    jump
   
}

