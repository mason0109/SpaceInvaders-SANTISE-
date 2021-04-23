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

    private bool playerDead = false;

    // Start is called before the first frame update
    void Start()
    {
        lives1.transform.position = new Vector3(-7.73f, 6.41f, 0f);
        lives2.transform.position = new Vector3(-6.44f, 6.41f, 0f);
        lives3.transform.position = new Vector3(-5.15f, 6.41f, 0f);
        EventSystem.current.onFinalHitPlayerDies += playerDies;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDead == false){
            //check the player's health
            checkPlayerHealth();
        }
    
    }

    void playerDies()
    {
        playerDead = true;
    }

    void checkPlayerHealth()
    {
        switch(player.GetComponent<PlayerMovement>().playerLives)
        {
            case 2:
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                //player.transform.position = new Vector3(-8.3f, -5.45f, -0.01f);
                break;
            case 1:
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                lives2.transform.position = new Vector3(-6.44f, 6.41f, -50f);
                //player.transform.position = new Vector3(-8.3f, -5.45f, -0.01f);
                break;
            case 0:
                lives1.transform.position = new Vector3(-7.73f, 6.41f, -50f);
                lives2.transform.position = new Vector3(-6.44f, 6.41f, -50f);
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                EventSystem.current.finalHitPlayerDies();
                break;
        }
    }
}
