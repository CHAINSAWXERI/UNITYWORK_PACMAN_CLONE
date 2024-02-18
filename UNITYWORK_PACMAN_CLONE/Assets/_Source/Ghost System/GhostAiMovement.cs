using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAiMovement : MonoBehaviour
{
    public float speed;
    public float viewRadius;
    public LayerMask playerLayer;

    private Transform playerTransform;
    private Vector3 direction;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerTransform.position - transform.position, viewRadius, playerLayer);
        if (hit.collider != null)
        {
            PursuitMode();
        }
        else
        {
            VagrancyMode();
        }
    }

    public void VagrancyMode()
    {
        Debug.Log("NOTHING");
    }

    public void PursuitMode()
    {
        direction = playerTransform.position - transform.position;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}


//PursuitMode -
//VagrancyMode -
/*
    public float speed = 10.0f;
    public float viewRadius = 10.0f;
    public LayerMask playerLayer;

    private Transform playerTransform;
    private Vector3 direction;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerTransform.position - transform.position, viewRadius, playerLayer);
        if (hit.collider != null)
        {
            direction = playerTransform.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }
*/