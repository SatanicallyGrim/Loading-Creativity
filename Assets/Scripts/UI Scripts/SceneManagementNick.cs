using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Changing scenes requires this
using UnityEngine.SceneManagement;

public class SceneManagementNick : MonoBehaviour
{
    // Is game paused?
    public static bool GameIsPaused = false;
    // Assigning name to a GameObject
    public GameObject pauseMenuUI;
    
    // Update is called once per frame
    void Update()
    {
        // if escape is pressed while game is not paused - the game pauses
        // if escape is pressed while game is paused - the game resumes
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        // Sets GameObject to be invisible
        pauseMenuUI.SetActive(false);
        // A time scale of 1 means game is running normally
        Time.timeScale = 1f;
        // Game is not paused
        GameIsPaused = false;
    }

    void Pause()
    {
        // Sets GameObject to visible
        pauseMenuUI.SetActive(true);
        // A time scale of 0 means game is halted
        Time.timeScale = 0f;
        // Game is paused
        GameIsPaused = true;
    }

    public void LoadAScene(string SceneName)
    { 
        Time.timeScale = 1f;
        // Loads a specific scene named in the OnClick() in the inspector
        SceneManager.LoadScene(SceneName);
    }

    public void QuitGame()
    {
        // Quits game when open as an application
        Application.Quit();
        // Quits play mode in the unity editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
