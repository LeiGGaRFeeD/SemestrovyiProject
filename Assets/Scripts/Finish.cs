using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
   public void OnTriggerEnter(Collider other)
   {
      if ( other.gameObject.GetComponent<FirstPersonController>() == true)
      {
         Debug.Log("GoToFinish");
         SceneManager.LoadScene("FinishA");
      }
   }
}
