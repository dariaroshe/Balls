using System;
using Balls;
using Service;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CollectBallsGame
{
    public class CollectPopupGameOverComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;
        
        public GameObject PopupGameOver;
        

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
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
            if (_gameModel.FailedBalls.Value == 0)
            {
                PopupGameOver.SetActive(true);
                _gameModel.CollectGameState.Value = CollectGameState.GameOver;
            }
        }
    }
}