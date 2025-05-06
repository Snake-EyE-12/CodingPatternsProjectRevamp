using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    
    
    
    
    
    
    public GameManager GetInstance()
    {
        if (instance == null)
        {
            instance = this;
        }

        return instance;
    }

    public static GameManager instance;

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public string GetActiveSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }
}