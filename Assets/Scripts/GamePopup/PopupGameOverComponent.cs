using Game;
using UnityEngine;

namespace GamePopup
{
    public class PopupGameOverComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        public GameObject PopupGameOver;

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
                PopupGameOver.SetActive(true);
                _gameModel.GameState.Value = GameState.GameOver;
            }
        }
    }
}