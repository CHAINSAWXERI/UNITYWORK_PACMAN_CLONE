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

        [SerializeField] public RedGhostAiMovement redGhost;
        [SerializeField] public PinkGhostAiMovement pinkGhost;
        [SerializeField] public BlueGhostAiMovement blueGhost;
        //[SerializeField] public RedGhostAiMovement redGhost;
        public ModePerformer performer;
        void Start()
        {
            playerModel = new PlayerModel();
            playerController = new PlayerController(playerModel, playerView);

            redGhost.performer = new ModePerformer(redGhost);
            redGhost._modeVagrancyStrategy = new VagrancyModeStrategy(redGhost.randomDirection, redGhost.ghostRigidBody, redGhost.speed);
            redGhost._modePursuitStrategy = new PursuitModeStrategy(redGhost.direction, redGhost.gameObject, redGhost.speed, redGhost.playerTransform, redGhost.ghostRigidBody);

            pinkGhost.performer = new ModePerformer(pinkGhost);
            pinkGhost._modeVagrancyStrategy = new VagrancyModeStrategy(pinkGhost.randomDirection, pinkGhost.ghostRigidBody, pinkGhost.speed);

            blueGhost.performer = new ModePerformer(blueGhost);
            blueGhost._runawayModeStrategy = new RunawayModeStrategy(blueGhost.direction, blueGhost.gameObject, blueGhost.speed, blueGhost.playerTransform, blueGhost.ghostRigidBody);
            blueGhost._modeVagrancyStrategy = new VagrancyModeStrategy(blueGhost.randomDirection, blueGhost.ghostRigidBody, blueGhost.speed);
            blueGhost._modePursuitStrategy = new PursuitModeStrategy(blueGhost.direction, blueGhost.gameObject, blueGhost.speed, blueGhost.playerTransform, blueGhost.ghostRigidBody);
        }
    }
}