using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
   public void RestartGame()
    {
        // Load your main game scene or perform any other action when the button is clicked.
        SceneManager.LoadScene("Menu");
    }
}
