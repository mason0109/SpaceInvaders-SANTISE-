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

    void Awake()
    {
        EventSystem.current.onCreditsOver += creditsOverChangeScene;
    }

    public void StartGame()
    {
        if (playerStats.Difficulty == "Easy")
        {
            StartCoroutine(LoadTheScene(1));
            playerStats.level = 1;
        }
        if (playerStats.Difficulty == "Medium")
        {
            StartCoroutine(LoadTheScene(3));
            playerStats.level = 1;
        }
        if (playerStats.Difficulty == "Hard")
        {
            StartCoroutine(LoadTheScene(5));
            playerStats.level = 1;
        }
        EventSystem.current.sceneChangeToGame();
    }

    IEnumerator LoadTheScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }

    public void loadCorrectLevel()
    {
        switch (playerStats.level)
        {
            case 1:
                    switch (playerStats.Difficulty)
                    {
                        case "Easy":
                                StartCoroutine(LoadTheScene(1));
                                break;
                        case "Medium":
                                StartCoroutine(LoadTheScene(3));
                                break;
                        case "Hard":
                                StartCoroutine(LoadTheScene(5));
                                break;
                    }
                    break;
            case 2:
                    switch (playerStats.Difficulty)
                    {
                        case "Easy":
                                StartCoroutine(LoadTheScene(2));
                                break;
                        case "Medium":
                                StartCoroutine(LoadTheScene(4));
                                break;
                        case "Hard":
                                StartCoroutine(LoadTheScene(6));
                                break;
                    }
                    break;
        }
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
        StartCoroutine(LoadTheScene(playerStats.level + 1));
        playerStats.level = 2;
    }

    public void LoadPlayer()
    {
        string playername = playerStats.username;
        DataToSave data = SaveSystem.LoadPlayer(playername);
        playerStats.level = data.level;
        playerStats.username = data.username;
        playerStats.Score = data.score;
        playerStats.totalTime = data.time;
        playerStats.Difficulty = data.Difficulty;

        loadCorrectLevel();
    }

    public void StartTutorial()
    {
        StartCoroutine(LoadTheScene(9));
    }

    public void StartTutorialLevel()
    {
        StartCoroutine(LoadTheScene(10));
    }

    public void LoadCredits()
    {
        StartCoroutine(LoadTheScene(13));
    }

    public void creditsOverChangeScene()
    {
        StartCoroutine(LoadTheScene(0));
    }
}
