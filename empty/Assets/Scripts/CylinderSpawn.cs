using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameObjectSpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private GameObject[] cylinder;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (true)  // Infinite loop, coroutine runs once each time it's invoked
        {
            yield return wait;
            SpawnCylinder();
        }
    }

    private void SpawnCylinder()
    {
        int rand = Random.Range(0, cylinder.Length);
        GameObject cylinderToSpawn = cylinder[rand];

        Instantiate(cylinderToSpawn, transform.position, Quaternion.identity);
    }
}