using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    private float timeElapsed;
    private bool isTiming;

   // public Text timerText; // Текстовое поле для отображения времени

    void Start()
    {
        timeElapsed = 0f;
        isTiming = true;
    }

    void Update()
    {
        if (isTiming)
        {
            timeElapsed += Time.deltaTime;
            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeElapsed / 60F);
        int seconds = Mathf.FloorToInt(timeElapsed % 60F);
        int milliseconds = Mathf.FloorToInt((timeElapsed * 100F) % 100F);
    //    timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    public void StopTimer()
    {
        isTiming = false;
    }

    public void SaveTime(string key)
    {
        PlayerPrefs.SetString(key, timeElapsed.ToString("F2"));
        PlayerPrefs.Save();
    }
}
