using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    Text scoreText;
    // [SerializeField]
    // private AudioSource AudioSrc;
    
    void Start () {
        // AudioSrc  = GetComponent<AudioSource> ();
        scoreText = GetComponent<Text> ();
        scoreAmount = 0;
    }

    void Update () {
        scoreText.text = "Score:" + scoreAmount;
        // if (scoreAmount == 9)
        // {
        // AudioSrc.Play(0);
        // }
    }
}
