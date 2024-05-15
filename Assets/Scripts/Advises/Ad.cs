using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Ad : MonoBehaviour
{
    public string TextForAdvise;
    private bool _isON;
    public Text TextUpdate;
    public void OnTriggerEnter(Collider other)
    {
        _isON = true;
    }

    public void OnTriggerExit(Collider other)
    {
        _isON = false;
    }

    public void Update()
    {
        if ( _isON == true)
        {
            TextUpdate.text = TextForAdvise.ToString();
        }
        else if (_isON == false)
        {
             string TextForAdvise = " ";
             TextUpdate.text = TextForAdvise.ToString();
        }
    }
}
