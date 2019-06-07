using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    public GameObject GameWonUI;


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

    public GameObject EnemyMothership;
    void Update()
    {

        if (EnemyMothership == null)
        {
            Debug.Log("You secured Space");
            GameWonUI.SetActive(true);
            Time.timeScale = 1f;
        }

    }
}
