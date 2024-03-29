using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private MarioMovement controller;
    public bool isGrounded;

    SFXManager sfxManager;

    SoundManager soundManager;


    void Awake() 
    {
        controller = GetComponentInParent<MarioMovement>();
        
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
            controller.anim.SetBool("IsJumping", false);
        }
        else if(other.gameObject.layer == 6)
        {
            Debug.Log("Goomba morto");

            sfxManager.GoombaDeath();

            Goomba goomba = other.gameObject.GetComponent<Goomba>();
            goomba.Die();

        }

        if(other.gameObject.tag == "DeadZone")
        {
            Debug.Log("Ta mortoo");
            
            sfxManager.MarioDeath();

            soundManager.StopBGM();
        }
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
            controller.anim.SetBool("IsJumping", false);
        }
    }
    
    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = false;
            controller.anim.SetBool("IsJumping", true);
        }
    }

}
