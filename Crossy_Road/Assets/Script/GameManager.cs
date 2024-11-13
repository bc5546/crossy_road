using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public static GameManager Instance
    {
        get 
        { 
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance; 
        }
    }

    private void Awake()
    {
        if (GameManager.instance != null) { Destroy(this); }
        else 
        {
            GameManager.instance = this;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("게임 오버");
    }
}
