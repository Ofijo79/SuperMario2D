using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public bool canShoot;
    public float powerUpDuration = 5;
    public float powerUpTimer = 0;

    private int score;
    public Text scoreText;

    public List<GameObject> goombasInScreen;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        ShootPowerUp();

        if(Input.GetKeyDown(KeyCode.P))
        {
            KillAllGoombas();
        }
    }

    public void GameOver()
    {
        isGameOver = true;

        // LoadScene();

        //Invoke("LoadScene", 2.5f);

        // empezar corutina
        StartCoroutine("LoadScene");
    }

    /* void LoadScene()
    {
        SceneManager.LoadScene(2);
    } */


    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(2);
    }
    
    public void AddCoin()
    {
        score++;
        scoreText.text = "x" + score;
    }

    void ShootPowerUp()
    {
        if(canShoot)
        {
            if(powerUpTimer <= powerUpDuration)
            {
                powerUpTimer += Time.deltaTime;
            }
            else
            {
                canShoot = false;
                powerUpTimer = 0;
            }
        }
    }

    void KillAllGoombas()
    {
        for (int i = 0; i < goombasInScreen.Count; i++)
        {
            Destroy(goombasInScreen[i]);
        }
    }
}
