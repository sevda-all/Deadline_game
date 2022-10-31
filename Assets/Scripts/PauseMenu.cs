using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    int sceneIndex;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    

    
    void Start(){
        sceneIndex = SceneManager.GetActiveScene ().buildIndex;
    }
     
    public void MenuGame(){
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void RestartGame(){
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;  
        GameIsPaused = false;
    }
     public void NextLevel(){
        SceneManager.LoadScene (sceneIndex + 1);
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause (){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    }

    public void QuitGame(){
        Debug.Log ("See you soon!");
        Application.Quit();
    }
}
