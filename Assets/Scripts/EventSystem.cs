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

    public event Action onGameOver;

    public void gameOver()
    {
        if (onGameOver != null)
        {
            onGameOver();
        }
    }

    public event Action onSceneChangeToGame;

    public void sceneChangeToGame()
    {
        if (onSceneChangeToGame != null)
        {
            onSceneChangeToGame();
        }
    }

    public event Action onSceneChangeToGameOver;

    public void sceneChangeToGameOver()
    {
        if (onSceneChangeToGameOver != null)
        {
            onSceneChangeToGameOver();
        }
    }

    public event Action onSceneChangeToHome;

    public void sceneChangeToHome()
    {
        if (onSceneChangeToHome != null)
        {
            onSceneChangeToHome();
        }
    }

    public event Action onReplayButtonClicked;

    public void replayButtonClicked()
    {
        if (onReplayButtonClicked != null)
        {
            onReplayButtonClicked();
        }
    }

    public event Action onEmeniesKilledLevelComplete;

    public void enemiesKilledLevelComplete()
    {
        if (onEmeniesKilledLevelComplete != null)
        {
            onEmeniesKilledLevelComplete();
        }
    }

    public event Action onEnemyKilled;

    public void  enemyKilled()
    {
        if (onEnemyKilled != null)
        {
            onEnemyKilled();
        }
    }

    public event Action onBulletHitBoundary;

    public void bulletHitBoundary()
    {
        if (onBulletHitBoundary != null)
        {
            onBulletHitBoundary();
        }
    }

    public event Action onDefenceHit;

    public void defenceHit()
    {
        if (onDefenceHit != null)
        {
            onDefenceHit();
        }
    }

    public event Action onCreditsOver;

    public void creditsOver()
    {
        if (onCreditsOver != null)
        {
            onCreditsOver();
        }
    }
} 
