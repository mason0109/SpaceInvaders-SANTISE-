using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvadedBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EventSystem.current.gameOver();
            Debug.Log("Game Over!");
        }
    }
}
