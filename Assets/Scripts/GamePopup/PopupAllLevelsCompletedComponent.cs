using Game;
using UnityEngine;

namespace GamePopup
{
    public class PopupAllLevelsCompletedComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public GameObject PopupAllLevelsCompleted;

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
            if (_gameModel.GameState.Value == GameState.AllLevelsCompleted)
            {
                PopupAllLevelsCompleted.SetActive(true);
            }
        }
    }
}