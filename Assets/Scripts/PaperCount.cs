using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PaperCount : MonoBehaviour
{

    void OnTriggerEnter2D (Collider2D col)
    {
        Score.scoreAmount += 10;
        Destroy (gameObject);
    }
    
        
}
