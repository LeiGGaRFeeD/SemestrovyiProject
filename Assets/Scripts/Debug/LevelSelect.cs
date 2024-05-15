using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneName.ToString());
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
