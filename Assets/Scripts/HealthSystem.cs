using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public GameObject live1;
    public GameObject live2;
    public GameObject live3;
    public GameObject GameOverUI;
    public static int health;

    void Start()
    {
        health = 3;
        live1.SetActive (true);
        live2.SetActive (true);
        live3.SetActive (true);
        GameOverUI.SetActive (false);
        
    }

    void Update()
    {
        if(health > 3)
            health = 3;
        
        switch (health)
        {
            case 3:
                live1.SetActive (true);
                live2.SetActive (true);
                live3.SetActive (true);
                break;
            case 2:
                live1.SetActive (true);
                live2.SetActive (true);
                live3.SetActive (false);
                break;
            case 1:
                live1.SetActive (true);
                live2.SetActive (false);
                live3.SetActive (false);
                break;
            case 0:
                live1.SetActive (false);
                live2.SetActive (false);
                live3.SetActive (false);
                GameOverUI.SetActive (true);
                Time.timeScale = 0f;
                break;
        }
    }
        
}
