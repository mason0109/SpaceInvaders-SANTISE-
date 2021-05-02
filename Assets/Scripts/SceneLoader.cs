using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        EventSystem.current.sceneChangeToGame();
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit.");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        EventSystem.current.sceneChangeToHome();
    }
}
