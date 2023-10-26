using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image HealthBar;
    public float amount = 100;
    //restarts if it reaches 0
    private void Update(){
        if(amount<=0){
            Application.LoadLevel(Application.loadedLevel);
        }

    }
    //Still need to set amount for damage each hit maybe 20 
    //Code works to take damage and reflect it on the health bar
    public void TakeDamage(float Damage){
        amount -= Damage;
        HealthBar.fillAmount = healthAmount/100;
    }
    // Trying to use triggers so when it interacts with a enemy it takes damage 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) 
        {
            TakeDamage();
        }
    }
}
