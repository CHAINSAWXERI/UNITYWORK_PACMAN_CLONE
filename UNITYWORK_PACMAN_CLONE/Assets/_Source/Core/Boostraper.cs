using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterSystem;

namespace Core
{
    public class Boostraper : MonoBehaviour
    {
        [SerializeField] public PlayerView playerView;
        public PlayerController playerController { get; private set; }
        public PlayerModel playerModel { get; private set; }
        void Start()
        {
            playerModel = new PlayerModel();
            playerController = new PlayerController(playerModel, playerView);
        }
    }
}