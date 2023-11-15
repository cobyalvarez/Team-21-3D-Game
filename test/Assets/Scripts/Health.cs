using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    public float chealth;
    public HeathBar healthb;

    private void Start(){
        chealth=maxHealth; 
        healthb.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float damage){
        chealth -= damage;
        healthb.SetSlider(chealth);
        // HealthBar.fillAmount = amount/100;
        if(chealth<=0){
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    private void Update(){
        if(chealth>maxHealth){
            chealth=maxHealth;
        }
    }
}
