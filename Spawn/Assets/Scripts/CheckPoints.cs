using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{
   private void OnTriggerEnter(Collider enter){
    if(enter.gameObject.name == "Slime_01_King"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
   }
}
