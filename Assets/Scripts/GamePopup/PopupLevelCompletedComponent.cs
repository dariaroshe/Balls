using Game;
using UnityEngine;

namespace GamePopup
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

            _gameModel.GameState.Changed += OnScoreChanged;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed -= OnScoreChanged;
        }

        private void OnScoreChanged()
        {
            if (_gameModel.GameState.Value == GameState.LevelCompleted)
            {
                PopupLevelCompleted.SetActive(true);
            }
        }
    }
}