using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    public float range = 25.0f; 
    private NavMeshAgent agent;
    private Vector3 position;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetRandomDestination();
    }
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.1f && agent.isOnNavMesh)
        {
            SetRandomDestination();
        }
    }
    private void SetRandomDestination()
    {
        Vector2 rnd = Random.insideUnitCircle * range;
        Vector3 point = new Vector3(rnd.x, 0f, rnd.y) + transform.position;
        if (NavMesh.SamplePosition(point, out NavMeshHit hit, range, NavMesh.AllAreas))
        {
            position = hit.position; 
            agent.SetDestination(position); 
        }
    }
}