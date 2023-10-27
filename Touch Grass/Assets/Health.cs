using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    public float health;
    public HeathBar healthb;

    private void start(){
        health=maxHealth; 
        healthb.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float damage){
        health -= damage;
        healthb.SetSlider(health);
        // HealthBar.fillAmount = amount/100;
        if(health<=0){
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
