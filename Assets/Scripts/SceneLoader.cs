using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private Animator transition;

    [SerializeField]
    private float transitionTime = 1f;

    [SerializeField]
    private PlayerStats playerStats;

    public void StartGame()
    {
        Debug.Log(playerStats.Difficulty);
        if (playerStats.Difficulty == "Easy")
        {
            StartCoroutine(LoadTheScene(1));
        }
        if (playerStats.Difficulty == "Medium")
        {
            StartCoroutine(LoadTheScene(3));
        }
        if (playerStats.Difficulty == "Hard")
        {
            StartCoroutine(LoadTheScene(5));
        }
        EventSystem.current.sceneChangeToGame();
    }

    IEnumerator LoadTheScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit.");
    }

    public void TryAgain()
    {
        StartCoroutine(LoadTheScene(0));
        EventSystem.current.sceneChangeToHome();
    }

    public void NextLevel()
    {
        StartCoroutine(LoadTheScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
}
