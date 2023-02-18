using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip marioDeath;

    public AudioClip goombaDeath;

    private AudioSource source;

    public AudioClip getCoin;

    public AudioClip finalLvl;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void GoombaDeath()
    {
        source.PlayOneShot(goombaDeath);
    }
    
    public void MarioDeath()
    {
        source.PlayOneShot(marioDeath);
    }
    public void GetCoin()
    {
        source.PlayOneShot(getCoin);
    }
    public void FinalLvl()
    {
        source.PlayOneShot(finalLvl);
    }

}
