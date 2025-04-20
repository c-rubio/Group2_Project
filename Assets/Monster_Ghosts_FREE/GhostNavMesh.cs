using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;

    private NavMeshAgent navMeshAgent;
    private float followDelay = 10f; // Delay in seconds
    private float timer = 0f;
    private bool canFollow = false;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // If not yet allowed to follow, increment timer
        if (!canFollow)
        {
            timer += Time.deltaTime;
            if (timer >= followDelay)
            {
                canFollow = true;
            }
            return; // Skip movement if still in delay period
        }

        // Start following once delay is over
        if (movePositionTransform != null)
        {
            navMeshAgent.destination = movePositionTransform.position;
        }
    }
}