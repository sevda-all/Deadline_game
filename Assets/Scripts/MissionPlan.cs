using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionPlan : MonoBehaviour
{
    public float StartTime;
    public float EndTime = 0.25f;

    void Start()
    {

    }

    void Update()
    {
        StartTime += 0.1f * Time.deltaTime;

        if(StartTime >= EndTime)
        {
           Destroy (gameObject);
        } 
    }
}
