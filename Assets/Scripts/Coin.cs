using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private bool _DebugIsOn;
    [SerializeField] private int _money;

  //  [SerializeField] private long house;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.GetComponent<FirstPersonController>() ==  true)
        {
           // _money = 1;
            PlayerPrefs.SetInt("money",PlayerPrefs.GetInt("money")+_money);
            Debug.Log(("Added coin"));
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ( _DebugIsOn = true)
        {
            if ( Input.GetKeyDown(KeyCode.R))
            {
                PlayerPrefs.SetInt("money", 0);
                Debug.Log("Coin restarted");
            }
        }

    }
}
