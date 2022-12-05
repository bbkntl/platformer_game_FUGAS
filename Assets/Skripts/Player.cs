using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int hearts = 3;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private TextMeshProUGUI textCoins;
    [SerializeField] private Hearts heart;
   // [SerializeField] public Joystic joystic;
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public int pointsCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coins")
        {
            pointsCount += 100;
            textCoins.text = pointsCount.ToString();
            GameObject coins = collision.gameObject;
            Destroy(coins);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Floor")
        {
            Damage();
        }
    }
    private void Damage()
    {
        hearts--;
        heart.RemuveHearts();
        if(hearts == 0)
        {
            Time.timeScale = 0;
            heart.GameOver();
        }
    }


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        //( joystic.Horizontal != 0)
            //(Input.GetButton("Horizontal"))
            Run();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal"); 
        //joystic.Horizontal;
        Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position + Vector3.down, 0.3f);
        isGrounded = collider.Length > 1;
    }


}
