using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossSceneSwitch : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         SceneManager.LoadScene("Boss");
      }
   }
}
