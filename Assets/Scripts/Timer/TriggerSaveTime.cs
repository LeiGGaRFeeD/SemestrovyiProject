using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class TriggerSaveTime : MonoBehaviour
{
    public LevelTimer levelTimer;
    public string playerPrefsKey = "LevelTime";

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonController>()== true)
        {
            levelTimer.StopTimer();
            levelTimer.SaveTime(playerPrefsKey);
        }
    }
}
