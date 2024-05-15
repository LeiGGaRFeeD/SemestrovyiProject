using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.GetComponent<FirstPersonController>() == true)
        {
            Debug.Log("Player out of level or fall down! Restarting level.");
            // Получаем активную сцену и её имя
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;

            // Перезагружаем сцену по её имени
            SceneManager.LoadScene(sceneName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
