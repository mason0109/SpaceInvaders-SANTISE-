using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

    [SerializeField]
    private GameObject lives1;

    [SerializeField]
    private GameObject lives2;

    [SerializeField]
    private GameObject lives3; 

    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        lives1.transform.position = new Vector3(-7.73f, 6.41f, 0f);
        lives2.transform.position = new Vector3(-6.44f, 6.41f, 0f);
        lives3.transform.position = new Vector3(-6.37f, 6.41f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //check the player's health
        checkPlayerHealth();
    }

    void checkPlayerHealth()
    {
        switch(playerLives)
        {
            // case 3:
            // case 2:
            // case 1:
            // case 0:
        }
    }
}
