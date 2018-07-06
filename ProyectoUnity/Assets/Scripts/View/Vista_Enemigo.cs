using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Vista_Enemigo : MonoBehaviour
{


    Enemigos enemigos = new Enemigos(10, 5, 5, 80);
    int x;
    GameObject waypointObj;
    Transform[] waypoints;
    int nextWaypoint;

    // Use this for initialization
    void Start()
    {
        enemigos.vida = x;
        waypointObj = GameObject.FindGameObjectWithTag("Waypoints");
        waypoints = new Transform[waypointObj.transform.childCount];
        for(int i = 0; i < waypointObj.transform.childCount; i++) {
            waypoints[i] = waypointObj.transform.GetChild(i);
        }
        nextWaypoint = 0;
    }

    void Update()
    {
        if (x == 0)
        {
            x = x - 1;

            Debug.Log("Se Elimino un enemigo");
            //Destroy(gameObject);
        }
        Movement();
        ProceedToNextWaypoint();
    }

    void Movement() {
        Vector3 direction = (waypoints[nextWaypoint].position - transform.position).normalized;
        transform.Translate(direction * Time.deltaTime, Space.World);
    }

    void ProceedToNextWaypoint() {
        // Check if current position is very near the next waypoint position
        float wpX = Mathf.Round(waypoints[nextWaypoint].position.x);
        float wpY = Mathf.Round(waypoints[nextWaypoint].position.y);
        if (Mathf.Round(transform.position.x) == wpX && Mathf.Round(transform.position.y) == wpY && nextWaypoint < waypoints.Length - 1) {
            nextWaypoint++;
            Debug.Log(nextWaypoint);
        }
    }

}