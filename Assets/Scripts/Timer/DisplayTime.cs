using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public Text timeText;
    public string playerPrefsKey = "LevelTime";

    void Start()
    {
        if (PlayerPrefs.HasKey(playerPrefsKey))
        {
            string savedTime = PlayerPrefs.GetString(playerPrefsKey);
            timeText.text = "Time: " + savedTime;
        }
        else
        {
            timeText.text = "No time recorded.";
        }
    }
}
