using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
