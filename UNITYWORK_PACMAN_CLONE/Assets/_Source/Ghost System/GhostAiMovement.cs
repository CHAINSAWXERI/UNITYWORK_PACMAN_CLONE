using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAiMovement : MonoBehaviour
{
    public float speed;
    public float viewRadius;
    public LayerMask playerLayer;
    public LayerMask wallLayer;

    private Transform playerTransform;
    private Vector3 direction;
    private int randomDirection;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        randomDirection = Random.Range(0, 4);
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

    public void PursuitMode()
    {
        direction = playerTransform.position - transform.position;
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void VagrancyMode()
    {
        // Инициализация случайного направления
        
        if (randomDirection == 0)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (randomDirection == 1)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else if (randomDirection == 2)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (randomDirection == 3)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("1");
        if (collision.gameObject.layer == wallLayer.value)
        {
            Debug.Log("2");
            randomDirection = Random.Range(0, 4);
        }
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