using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlueGhostAiMovement : MonoBehaviour, GhostAiMovement
{
    [SerializeField] public Transform playerTransform;
    [SerializeField] public float speed;
    [SerializeField] public Rigidbody2D ghostRigidBody;
    [SerializeField] private float viewRadius;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private LayerMask wallLayer;

    public Vector3 direction { get; private set; }
    public int randomDirection { get; private set; }

    private IModeStrategy currentStrategy;
    public ModePerformer performer;
    public VagrancyModeStrategy _modeVagrancyStrategy;
    public PursuitModeStrategy _modePursuitStrategy;
    public RunawayModeStrategy _runawayModeStrategy;

    void Start()
    {
        randomDirection = Random.Range(0, 4);
        InvokeRepeating("ChangeDirection", 0f, 20f);
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerTransform.position - transform.position, viewRadius, playerLayer);
        if (hit.collider != null)
        {
            if (Random.Range(0, 5) == 0)
            {
                PerformRunawayMode();
            }
            else
            {
                PerformPursuitMode();
            }
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
            if (_modeVagrancyStrategy.randomDirection == 0)
            {
                _modeVagrancyStrategy.randomDirection = Random.Range(1, 4);
            }
            else if (_modeVagrancyStrategy.randomDirection == 1)
            {
                int[] numbers = { 0, 2, 3 };
                _modeVagrancyStrategy.randomDirection = numbers[Random.Range(0, numbers.Length)];
            }
            else if (_modeVagrancyStrategy.randomDirection == 2)
            {
                int[] numbers = { 0, 1, 3 };
                _modeVagrancyStrategy.randomDirection = numbers[Random.Range(0, numbers.Length)];
            }
            else if (_modeVagrancyStrategy.randomDirection == 3)
            {
                _modeVagrancyStrategy.randomDirection = Random.Range(0, 3);
            }
        }
    }

    private void ChangeDirection()
    {
        if (_modeVagrancyStrategy.randomDirection == 0)
        {
            _modeVagrancyStrategy.randomDirection = Random.Range(1, 4);
        }
        else if (_modeVagrancyStrategy.randomDirection == 1)
        {
            int[] numbers = { 0, 2, 3 };
            _modeVagrancyStrategy.randomDirection = numbers[Random.Range(0, numbers.Length)];
        }
        else if (_modeVagrancyStrategy.randomDirection == 2)
        {
            int[] numbers = { 0, 1, 3 };
            _modeVagrancyStrategy.randomDirection = numbers[Random.Range(0, numbers.Length)];
        }
        else if (_modeVagrancyStrategy.randomDirection == 3)
        {
            _modeVagrancyStrategy.randomDirection = Random.Range(0, 3);
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

    public void PerformRunawayMode()
    {
        performer.PerformMode(_runawayModeStrategy);
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
