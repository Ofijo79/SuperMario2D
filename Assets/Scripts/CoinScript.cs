using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Mario Mortoo");
            Destroy(this.gameObject);
        }
    }
}
