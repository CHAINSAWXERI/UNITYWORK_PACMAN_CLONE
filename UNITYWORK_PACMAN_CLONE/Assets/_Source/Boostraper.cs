using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    [SerializeField] public PlayerView playerView;
    private PlayerController playerController;
    private PlayerModel playerModel;
    void Start()
    {
        playerModel = new PlayerModel();
        playerController = new PlayerController(playerModel, playerView);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            playerController.GetScore(100);
        }

        if (Input.GetKey(KeyCode.E))
        {
            playerController.GetHealth();
        }
    }
}
