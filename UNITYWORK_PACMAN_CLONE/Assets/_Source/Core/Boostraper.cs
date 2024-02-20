using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterSystem;
using UnityEngine.TextCore.Text;

namespace Core
{
    public class Boostraper : MonoBehaviour
    {
        [SerializeField] public PlayerView playerView;
        public PlayerController playerController { get; private set; }
        public PlayerModel playerModel { get; private set; }

        [SerializeField] public GhostAiMovement ghost;
        public ModePerformer performer;
        void Start()
        {
            playerModel = new PlayerModel();
            playerController = new PlayerController(playerModel, playerView);

            ghost.performer = new ModePerformer(ghost);
            ghost._modeVagrancyStrategy = new VagrancyModeStrategy(ghost.randomDirection, ghost.gameObject, ghost.speed);
            ghost._modePursuitStrategy = new PursuitModeStrategy(ghost.direction, ghost.gameObject, ghost.speed, ghost.playerTransform);
        }
    }
}