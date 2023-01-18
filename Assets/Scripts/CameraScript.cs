using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject Tarjet;
    private Vector3 TarjetPos;

    public float HaciaAdelante;
    public float Smoothing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TarjetPos = new Vector3(Tarjet.transform.position.x, Tarjet.transform.position.y, transform.position.z);

        if(Tarjet.transform.localScale.x == 1)
        {
            TarjetPos = new Vector3(TarjetPos.x + HaciaAdelante, TarjetPos.y, transform.position.z);
        }
        if(Tarjet.transform.localScale.x == -1)
        {
            TarjetPos = new Vector3(TarjetPos.x + HaciaAdelante, TarjetPos.y, transform.position.z);
        }

        transform.position = Vector3.Lerp(transform.position, TarjetPos, Smoothing * Time.deltaTime);
    }
}
