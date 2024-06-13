using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    // This method will be called when the Start button is pressed
    public void StartGame()
    {
        // Load the main game scene
        SceneManager.LoadScene("MainGameScene");
    }

    // This method will be called when the Quit button is pressed (optional)
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}