using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsOverScript : MonoBehaviour
{
    void Awake()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(20);
        SceneManager.LoadScene(0);
    }
}
