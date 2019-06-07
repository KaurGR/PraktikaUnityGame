using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Controls()
    {
        SceneManager.LoadScene("ControlsScene");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
