using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePlayer : MonoBehaviour
{
    public NavMeshAgent agent;
    private int currentWaypoint;
    
    [SerializeField]
    public GameObject waypoint;
    /*
     * Since we want to use multiple waypoints, we need to create a List<> of waypoints.
     * Do this and fill the list with the waypoints you want to use.
    */
    
    /*
     * Since we are using multiple waypoints and the player needs to move from waypoint to waypoint,
     * without stopping at a waypoint first, we need to have an offset.
     * This gives the program time to calculate the new best route.
     * Create this and use it in an if-statement.
     *
     * (Tip: the agent has a .remainingDistance property that you can use)
    */
    
    // Start is called before the first frame update
    void Start()
    {
        currentWaypoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(waypoint.transform.position);
    }
}
