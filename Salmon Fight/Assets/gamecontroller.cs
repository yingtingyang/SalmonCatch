using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class gamecontroller: MonoBehaviour
{
    public GameObject fish;
    public Vector3 maxPos;
    

    public Text scoreHolder;
    public Text restartText;
    public Text gameOverText;

    private bool gameOver;
    private bool restart;
    private int score;
   

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        
    }

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        if (gameOver)
        {
            restartText.text = "Press 'R' to restart";
            restart = true;
            
        }
    }



    void Spawn()
    
        
        {
            Instantiate(fish, new Vector3(Random.value * maxPos.x,
                                                  Random.value * maxPos.y,
                                                  Random.value * maxPos.z), Quaternion.identity );
        print("howdy");
        }
    

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreHolder.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOver = true;
    }
}