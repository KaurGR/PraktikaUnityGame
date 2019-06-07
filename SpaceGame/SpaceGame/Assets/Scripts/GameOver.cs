using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI;


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

    public GameObject Player;
    void Update()
    {
        
        if (Player == null)
        {
            Debug.Log("Aliens captured space");
            GameOverUI.SetActive(true);
            Time.timeScale = 0.5f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
}
