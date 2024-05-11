using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //var
    public GameObject gameOverCanvas;
    public GameObject startCanvas;
    public Flap bird;
    public bool gameStatus = false;

    //Functions
    private void Start()
    {
        gameStatus = false;
        gameOverCanvas.SetActive(false);
        startCanvas.SetActive(true);
        bird.toggleGravityOff();
    }

    public void GameOver()
    {
        gameStatus = false;
        startCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void Play()
    {
        Score.score = 0;
        startCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        gameStatus = true;
        bird.gameReset();
        bird.toggleGravityOn();
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

}
