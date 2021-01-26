using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunOnMyPoints : MonoBehaviour
{
    public Vector3[] waypoints;
    public float speed = 0;
    public Curve curve;
    int currentWaypointIndex;

    public void Start()
    {

        waypoints = curve.curvePositions;
        Debug.Log("Curve : " + curve.curvePositions.Length);
    }

    public void Update()
    {
        if (waypoints.Length > 0)
        {
            if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex]) < .1f)
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex], speed * Time.deltaTime);
                transform.rotation = Quaternion.LookRotation(waypoints[currentWaypointIndex] - transform.position);

            }
        }
    }
}
