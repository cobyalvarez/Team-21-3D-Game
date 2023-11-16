using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Slime_01_King"){
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.name == "Slime_01_King"){
            collision.gameObject.transform.SetParent(null);
        }
    }
}
