﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    

    public void QuitGame(){
        Debug.Log ("See you soon!");
        Application.Quit();
    }
}
