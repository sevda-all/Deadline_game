using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    [SerializeField]    
    public GameObject Player;
    
    void Update()
    {
        transform.position = new Vector3 ( Player.transform.position.x, 0.05f, -10f);
    }
}
