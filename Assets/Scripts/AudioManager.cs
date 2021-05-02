using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    
    public ASound[] AllSounds;

    public static AudioManager AManager;

    public ASound currentSound;

    public string soundToPlay;

    // Start is called before the first frame update
    void Awake()
    {
        if (AManager == null)
        {
            AManager = this;
        } else 
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        foreach (ASound s in AllSounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Audio;
            s.source.volume = s.Volume;
        }
    }

    void Start()
    {
        EventSystem.current.onSceneChangeToGame += playGameSoundtrack;
        //EventSystem.current.onSceneChangeToGameOver += playNormalSoundtrack;
        EventSystem.current.onSceneChangeToHome += playNormalSoundtrack;
        checkScene();
        PlaySound(soundToPlay);
    }

    public void PlaySound(string soundName)
    {
        currentSound = Array.Find(AllSounds, sound => sound.Name == soundName);
        if (currentSound == null)
        {
            Debug.Log("File not found: " + currentSound);
            return;
        }
        currentSound.source.Play();
    }

    public void playGameSoundtrack()
    {
        currentSound.source.Pause();
        PlaySound("MainGameSound");
    }

    public void playNormalSoundtrack()
    {
        currentSound.source.Pause();
        PlaySound("HomeScreenSound");
    }

    public void pauseCurrentSoundtrack()
    {
        currentSound.source.Pause();
    }

    public void checkScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "HomeScreen")
        {
            soundToPlay = "HomeScreenSound";   
        } 
        if (sceneName == "GameScreen")
        {
            soundToPlay = "MainGameSound";
        }
        if (sceneName == "GameOverScene")
        {
            soundToPlay = "HomeScreenSound";
        }
    }
}
