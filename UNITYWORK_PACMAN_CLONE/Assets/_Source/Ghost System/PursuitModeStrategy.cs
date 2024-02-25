using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class PursuitModeStrategy : IModeStrategy
{
    private Vector2 direction;
    private float speed;
    private GameObject ghost;
    private Rigidbody2D rigidbodyGhost;
    private Transform playerTransform;
    public PursuitModeStrategy(Vector2 dr, GameObject go, float sp, Transform pltr, Rigidbody2D rb) 
    {
        direction = dr;
        ghost = go;
        speed = sp;
        playerTransform = pltr;
        rigidbodyGhost = rb;
    }
    public void PerformMode()
    {
        direction = (playerTransform.position - ghost.transform.position).normalized;
        rigidbodyGhost.velocity = direction * speed;
    }
}

