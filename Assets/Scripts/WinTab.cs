using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinTab : MonoBehaviour
{
    int sceneIndex;
    Text scoreText;
    public GameObject nextLevelUI;

    void Start(){
        sceneIndex = SceneManager.GetActiveScene ().buildIndex;
    }

    void Update ()
    {   
        if(Score.scoreAmount == 100)
        {
            nextLevelUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
 