using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static Vector2 buttomLeft;
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool gameStarted;
    public GameObject getReady;
    public static int gameScore;
    public GameObject score;
    private void Awake()
    {
        buttomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameStarted = false;
    }
    public void GameHasStarted()
    {
        gameStarted= true;
        getReady.SetActive(false);
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        score.SetActive(false);
        gameScore = score.GetComponent<Score>().GetScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
