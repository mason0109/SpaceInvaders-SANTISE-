using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{

    //static singleton reference to the script.
    public static EventSystem current;

    public void Awake()
    {
        current = this;   
    }

    public event Action onLeftBoundaryTurn;

    public void leftBoundaryTurn()
    {
        if (onLeftBoundaryTurn != null)
        {
            onLeftBoundaryTurn();
        }
    }

    public event Action onRightBoundaryTurn;

    public void rightBoundaryTurn()
    {
        if (onRightBoundaryTurn != null)
        {
            onRightBoundaryTurn();
        }
    }

    public event Action onPlayerHitTakeALife;

    public void playerHitTakeALife()
    {
        if (onPlayerHitTakeALife != null)
        {
            onPlayerHitTakeALife();
        }
    }

    public event Action onFinalHitPlayerDies;

    public void finalHitPlayerDies()
    {
        if (onFinalHitPlayerDies != null)
        {
            onFinalHitPlayerDies();    
        }
    }

    public event Action onEnemyKilledIncreaseScore;

    public void enemyKilledIncreaseScore()
    {
        if (onEnemyKilledIncreaseScore != null)
        {
            onEnemyKilledIncreaseScore();
        }
    }
} 
