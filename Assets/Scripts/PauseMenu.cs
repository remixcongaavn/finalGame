using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("1Intro");
    }

    public void QuitMenu()
    {
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("3Exit");
    }

    public void saveGame()
    {
        PlayerPrefs.SetInt("score", ScoreButton.scoreUpdate);
        PlayerPrefs.SetInt("lives", LivesButton.liveUpdate);
        PlayerPrefs.SetString("name", NameTransfer.theName);
        Debug.Log("Saved game.........Name: " + NameTransfer.theName + " Score: " + ScoreButton.scoreUpdate + " lives: " + LivesButton.liveUpdate);
    }

    public void loadGame()
    {
        ScoreButton.scoreUpdate = PlayerPrefs.GetInt("score");
        LivesButton.liveUpdate = PlayerPrefs.GetInt("lives");
        NameTransfer.theName = PlayerPrefs.GetString("name");
        SceneManager.LoadScene("Game");
        Resume();

        Debug.Log("Loading save game.......Name: " + NameTransfer.theName + " Score: " + ScoreButton.scoreUpdate + " lives: " + LivesButton.liveUpdate);
    }
}
