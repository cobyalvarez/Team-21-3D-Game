using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    //To patrol
    public Vector3 walkPoint; 
    bool walkPointSet;
    public float walkPointRange; 


    // To Attack 
    public float timeAttacks;
    bool attacked;

    //Current States

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange; 

    private void Awake(){
        player = GameObject.Find("Slime_01_King").transform;
        agent = GetComponent<NavMeshAgent>();
    } 

    // Update is called once per frame
    private void Update()
    {
     //Check for enemy sight range and their range of attack
     playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
     playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

    if(!playerInSightRange && !playerInAttackRange){
        Patroling();
    }

    if(playerInSightRange && !playerInAttackRange){
        Chase();
    }
    if(playerInSightRange && playerInAttackRange){
        Attack();
    }
    }

    private void Patroling(){
        if(!walkPointSet){
            SearchWalkPoint();
        }
        if(walkPointSet){
            agent.SetDestination(walkPoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if(distanceToWalkPoint.magnitude< 1f){
            walkPointSet=false;
        }
    }

    private void SearchWalkPoint(){
        float currx = Random.Range(-walkPointRange,walkPointRange);
        float currz = Random.Range(-walkPointRange,walkPointRange);
        walkPoint = new Vector3(transform.position.x + currx,transform.position.y, transform.position.z + currz);

        if(Physics.Raycast(walkPoint,-transform.up,2f,whatIsGround)){
            walkPointSet=true;
        }
    }

    private void Chase(){
        agent.SetDestination(player.position);
    }

    private void Attack(){
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if(!attacked){
            attacked=true;
            Invoke(nameof(ResetAttack),timeAttacks);
        }
    }

    private void ResetAttack(){
        attacked=false;
    }


}
