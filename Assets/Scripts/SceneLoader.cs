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

    public void StartGame()
    {
        StartCoroutine(LoadTheScene(SceneManager.GetActiveScene().buildIndex + 1));
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        EventSystem.current.sceneChangeToHome();
    }
}
