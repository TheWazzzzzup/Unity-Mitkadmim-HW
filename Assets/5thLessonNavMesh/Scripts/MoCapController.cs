using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class MoCapController : MonoBehaviour
{
    [SerializeField] Animator animatorScript;
    [SerializeField] NavMeshAgent nmAgent;
    [SerializeField] Transform dest;
    [SerializeField] UnityEvent playerStateMove;

    private void Start()
    {
        nmAgent.SetDestination(dest.position);
        playerStateMove.AddListener(playerMoving);
    }

    private void Update()
    {
        if (nmAgent.isOnOffMeshLink)
        {
            animatorScript.SetBool("Jumping", true);
        }
        else
        {
            if (nmAgent.hasPath && animatorScript.GetBool("IsIdle") == true)
            {
                playerStateMove.Invoke();
            }
            else if (nmAgent.remainingDistance <= 0.2)
            {
                animatorScript.SetBool("GoalReached", true);
            }
        }
    }

    public void playerMoving()
    {
        animatorScript.SetBool("IsIdle", false);
    }


}