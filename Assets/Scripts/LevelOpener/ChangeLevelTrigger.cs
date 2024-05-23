using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevelTrigger : MonoBehaviour
{
    public int LevelCompleted;
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Changed opened level to "+LevelCompleted);
        PlayerPrefs.SetInt("Level",LevelCompleted); //changing level
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
