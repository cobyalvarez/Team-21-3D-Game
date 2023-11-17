using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level03Life : MonoBehaviour
{
    public int enemyDestroyed = 0;
    public int totalEnemy = 4;
    public GameObject Checkpoints;
    public GameObject targetObject;


    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy")){
            Die();
        }
        else if (collision.gameObject.CompareTag("Enemy Head")){
            Destroy(collision.transform.parent.gameObject);
            enemyDestroyed++;
            Debug.Log("Enemies:" + enemyDestroyed);

            if(enemyDestroyed == 3){
                Checkpoints.transform.position = targetObject.transform.position;
            }
        }
    }
    
    void Die(){
    GetComponent<MeshRenderer>().enabled=false;
    GetComponent<Rigidbody>().isKinematic = true;
    GetComponent<PlayerMovement>().enabled = false;
    Invoke(nameof(ReloadLevel),1.3f);
    }

    void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
