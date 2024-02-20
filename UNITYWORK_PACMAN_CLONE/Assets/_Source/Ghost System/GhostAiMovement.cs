using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAiMovement : MonoBehaviour
{
    [SerializeField] public Transform playerTransform;
    [SerializeField] public float speed;
    [SerializeField] private float viewRadius;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private LayerMask wallLayer;

    public Vector3 direction { get; private set; }
    public int randomDirection { get; private set; }

    private IModeStrategy currentStrategy;
    public ModePerformer performer;
    public VagrancyModeStrategy _modeVagrancyStrategy;
    public PursuitModeStrategy _modePursuitStrategy;

    void Start()
    {
        randomDirection = Random.Range(0, 4);
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerTransform.position - transform.position, viewRadius, playerLayer);
        if (hit.collider != null)
        {
            PerformPursuitMode();
        }
        else
        {
            PerformVagrancyMode();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (wallLayer == (wallLayer | (1 << collision.gameObject.layer)))
        {
            _modeVagrancyStrategy.randomDirection = Random.Range(0, 4);
        }
    }

    public void PerformPursuitMode()
    {
        performer.PerformMode(_modePursuitStrategy);
    }

    public void PerformVagrancyMode()
    {
        performer.PerformMode(_modeVagrancyStrategy);
    }

    public void SetStrategy(IModeStrategy strategy)
    {
        currentStrategy = strategy;
    }

    public void PerformMode()
    {
        currentStrategy.PerformMode();
    }
}