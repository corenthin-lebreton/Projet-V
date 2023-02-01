using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Animator animator;
    private NavMeshAgent agent;

    [SerializeField] private float  attackDelay = 3f;

    private float time;
    // Start is called before the first frame updated
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Animation();
        Attack();
    }



    private void Attack()
    {
        if(isInRange()){
            time += Time.deltaTime;
            if(time >= attackDelay){
                animator.SetTrigger("Attack");
                time = 0f;

            }
        }

    }
    private void Movement()
    {
        agent.SetDestination(player.transform.position);
    }

    private void Animation(){
    animator.SetBool("inRange", isInRange());
        
    }

    private bool isInRange(){
        return agent.hasPath && agent.remainingDistance < agent.stoppingDistance;
    }
}
