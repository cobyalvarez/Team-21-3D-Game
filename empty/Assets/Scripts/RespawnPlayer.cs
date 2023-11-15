using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour{
 public Transform spawnPoint; // Reference to the spawn point
 public Transform spawnPoint2;

    void OnTriggerEnter(Collider collision)
    {
        // Check if the player enters the kill zone
        if (collision.gameObject.CompareTag("KillZone"))
        {
            Respawn();
        }
        if (collision.gameObject.CompareTag("KillZone1")){
            Respawn2();
        }
    }

    private void Respawn()
    {
    transform.position = spawnPoint.position;
    }
    private void Respawn2()
    {
    transform.position = spawnPoint2.position;
    }
}
