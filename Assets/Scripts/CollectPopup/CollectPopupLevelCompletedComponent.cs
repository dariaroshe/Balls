using Balls;
using Service;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CollectBallsGame
{
    public class CollectPopupLevelCompletedComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public GameObject PopupLevelCompleted;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.CollectGameState.Changed += OnScoreChanged;
        }

        private void OnDestroy()
        {
            _gameModel.CollectGameState.Changed -= OnScoreChanged;
        }

        private void OnScoreChanged()
        {
            if (_gameModel.CollectGameState.Value == CollectGameState.LevelCompleted)
            {
                PopupLevelCompleted.SetActive(true);
            }
        }
    }
}