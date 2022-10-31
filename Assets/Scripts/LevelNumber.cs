using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumber : MonoBehaviour
{
    Text text;
    int sceneIndex;

    void Start()
    {
        text = GetComponent<Text> ();
        sceneIndex = SceneManager.GetActiveScene ().buildIndex; 
        Time.timeScale = 1f;
    }

    void Update()
    {
        text.text = " " + sceneIndex;
    }
}
