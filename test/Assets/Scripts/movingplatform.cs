using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{   
    //gets the different waypoints in the game
    [SerializeField] GameObject[] waypoints;

    //sets the index of them to change between
    int currentWaypointIndex = 0;

    //speed of the platform moving
    [SerializeField] float speed =1f;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,waypoints[currentWaypointIndex].transform.position) < .1f){
            currentWaypointIndex++;
            if(currentWaypointIndex>=waypoints.Length){
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position,speed * Time.deltaTime);

    }
}
