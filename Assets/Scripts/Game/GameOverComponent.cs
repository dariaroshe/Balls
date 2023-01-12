using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameOverComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _gameModel.FailedBalls.Changed += OnFailedBallsChanged;
        }

        private void OnDestroy()
        {
            _gameModel.FailedBalls.Changed -= OnFailedBallsChanged;
        }

        private void OnFailedBallsChanged()
        {
            if (_gameModel.FailedBalls.Value >= _gameScene.FailedBallsLooseValue)
            {
                _gameModel.GameState.Value = GameState.GameOver;
            }
        }
    }
}