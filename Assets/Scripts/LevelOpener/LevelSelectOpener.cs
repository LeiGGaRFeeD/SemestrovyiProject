using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectOpener : MonoBehaviour
{
    [SerializeField] private GameObject[] _levels;
    private int _levelOpened;
    // Start is called before the first frame update
    void Start()
    {
        for (int  i = 0;  i < _levels.Length;  i++)
        {
            _levels[i].SetActive(false);
        }
        _levelOpened = PlayerPrefs.GetInt("Level");
    }

    public void LevelOpen()
    {
        if (_levelOpened == 0)
        {
            for (int i = 0; i < _levels.Length; i++)
            {
                Debug.Log("");
                _levels[i].SetActive(false);
            }
        }

        if ( _levelOpened >= 1)
        {
            _levels[1].SetActive(true);
        }
        if ( _levelOpened >= 2)
        {
            _levels[2].SetActive(true);
        }
        if ( _levelOpened >= 3)
        {
            _levels[3].SetActive(true);
        }
        if ( _levelOpened >= 4)
        {
            _levels[4].SetActive(true);
        }
        if ( _levelOpened >= 5)
        {
            _levels[5].SetActive(true);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        LevelOpen(); 
    }
}
