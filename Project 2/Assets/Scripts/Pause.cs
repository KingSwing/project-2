using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    //Create boolean to store if the game is paused
    //The name makes no intuitive sense, but it works client side so it stays for now
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

	// Update is called once per frame
	void Update () {
        //P is the current pause button, I REALLY need to make this an input later so it can work on a gamepad
		if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
	}

    public void ResumeGame ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void PauseGame ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame ()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
