using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeGhostAiMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 1.0f;
    private int currentWaypoint = 0;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (currentWaypoint >= waypoints.Length)
        {
            currentWaypoint = 0;
        }

        Vector2 direction = (waypoints[currentWaypoint].position - transform.position).normalized;
        rb.velocity = direction * speed;

        if (Vector2.Distance(transform.position, waypoints[currentWaypoint].position) < 0.1f)
        {
            currentWaypoint++;
        }
    }
}
