using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;
    public GameObject GameOverScene;
    public AudioSource audioSource;
    public AudioSource backgroundAudio;
    // Start is called before the first frame update
    void Start()
    {
        backgroundAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int point)
    {
        Score += point;
        ScoreText.text = "Score: " + Score.ToString();
        audioSource.Play();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GameOver()
    {
        GameOverScene.SetActive(true);
    }
}
