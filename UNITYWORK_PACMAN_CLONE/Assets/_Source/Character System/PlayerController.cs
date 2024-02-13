using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

namespace CharacterSystem
{
    public class PlayerController
    {
        private PlayerModel _scoreModel;
        private PlayerView _scoreView;

        public PlayerController(PlayerModel scoreModel, PlayerView scoreView)
        {
            _scoreModel = scoreModel;
            _scoreView = scoreView;
        }

        public void GetScore(int AddScore)
        {
            _scoreModel.AddScore(AddScore);
            _scoreView.UpdateText(_scoreModel.Score);
        }

        public void GetHealth()
        {
            _scoreModel.SubtractLife(1);
            _scoreView.UpdateHealth(_scoreModel.Health);
        }
    }
}

