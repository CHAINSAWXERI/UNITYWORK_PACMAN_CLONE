using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursuitModeStrategy : IModeStrategy
{
    private Vector2 direction;
    private float speed;
    private GameObject ghost;
    private Transform playerTransform;
    public PursuitModeStrategy(Vector2 dr, GameObject go, float sp, Transform pltr) 
    {
        direction = dr;
        ghost = go;
        speed = sp;
        playerTransform = pltr;
    }
    public void PerformMode()
    {
        direction = playerTransform.position - ghost.transform.position;
        ghost.transform.Translate(direction * speed * Time.deltaTime);
    }
}

