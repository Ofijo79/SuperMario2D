using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject goombaPrefab;

    public int goombaToSpawn;

    //public Transform[] spawnPositions  = new Transform[3]{};

    public Transform[] spawnPositions;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGoomba", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(goombaToSpawn == 0)
        {
            CancelInvoke();
        }
    }

    void SpawnGoomba()
    {
        /*Transform selectedSpawn = spawnPositions[Random.Range(0, spawnPositions.Length)];

        Instantiate(goombaPrefab, selectedSpawn.position, selectedSpawn.rotation);*/

        foreach(Transform spawn in spawnPositions)
        {
            Instantiate(goombaPrefab, spawn.position, spawn.rotation);
        }

        /*for(int i = 0; i < spawnPositions.Length; i++)
        {
            Instantiate(goombaPrefab, spawnPositions[i].position, spawnPositions[i].rotation);
        }*/

        /*int i = 0;
        while(i < spawnPositions.Length)
        {
            Instantiate(goombaPrefab, spawnPositions[i].position, spawnPositions[i].rotation);
            i++;
        }*/

        /*int i = 0;
        do
        {
            Instantiate(goombaPrefab, spawnPositions[i].position, spawnPositions[i].rotation);
            i++;
        }while(i < spawnPositions.Length);*/

        goombaToSpawn--;
    }
}
