using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
    int playerHealth = 3;
    public float playerSpeed = 5.5f;
    string texto = "Hello World";
    private SpriteRenderer spriteRenderer;
    float horizontal;
    private Rigidbody2D rBody;
    public float jumpForce = 3f;
    private GroundSensor sensor;
    public Animator anim;
    SFXManager sfxManager;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        sensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
        rBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        playerHealth = 10;
        Debug.Log(texto); 

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameOver == false) 
        {
            horizontal = Input.GetAxis("Horizontal");

            //transform.position += new Vector3(horizontal,0,0) * playerSpeed * Time.deltaTime;

            if(horizontal < 0)
            {
                spriteRenderer.flipX = true;
                anim.SetBool("IsRunning", true);
            }
            else if(horizontal > 0)
            {
                spriteRenderer.flipX = false;
                anim.SetBool("IsRunning", true);
            }
            else
            {
                anim.SetBool("IsRunning", false);
            }

            if(Input.GetButtonDown("Jump") && sensor.isGrounded)
            {
                rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                anim.SetBool("IsJumping", true);
            }
        }

        
    }

    void FixedUpdate() 
    {
        rBody.velocity = new Vector2(horizontal * playerSpeed, rBody.velocity.y);    
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Coin")
        {
            gameManager.AddCoin();
            sfxManager.GetCoin();
            Destroy(collision.gameObject);
        }
    }
}
