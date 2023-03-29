using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    Rigidbody2D rBody2D;

    public float ballSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {
        rBody2D = GetComponent<Rigidbody2D>();

        rBody2D.AddForce(transform.right * ballSpeed, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
       if(collider.gameObject.layer == 6)
       {
        Goomba goomba = collider.gameObject.GetComponent<Goomba>();
        goomba.Die();
       } 

       if(collider.gameObject.tag == "Player" || collider.gameObject.tag == "Coin" || collider.gameObject.tag == "FireBall")
       {
            return;
       }
       Destroy(this.gameObject); 

    }
}
