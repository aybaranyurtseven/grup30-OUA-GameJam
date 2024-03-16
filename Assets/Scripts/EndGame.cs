using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject gameOverPanel; // Oyun bittiğinde gösterilecek panel
    public GameObject victoryPanel; // Oyun bittiğinde gösterilecek panel

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        // Oyun bittiğinde paneli göster
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Victory()
    {
       victoryPanel.SetActive(true);
       Time.timeScale = 0;
    }
    
    public void RestartLevel()
    {
        Debug.Log("Selam");
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneBuildIndex:0);

    }
}