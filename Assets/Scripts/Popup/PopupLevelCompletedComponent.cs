using CollectBallsGame;
using Game;
using UnityEngine;

namespace Popup
{
    public class PopupLevelCompletedComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public GameObject PopupLevelCompleted;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _gameModel.Score.Changed += OnScoreChanged;
        }

        private void OnDestroy()
        {
            _gameModel.Score.Changed -= OnScoreChanged;
        }

        private void OnScoreChanged()
        {
            if (_gameModel.Score.Value >= _gameScene.MinAmountCollectBalls)
            {
                PopupLevelCompleted.SetActive(true);
                _gameModel.GameState.Value = GameState.LevelCompleted;
            }
        }
    }
}