using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        
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
}
