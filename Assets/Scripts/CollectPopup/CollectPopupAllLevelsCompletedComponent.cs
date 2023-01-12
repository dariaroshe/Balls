using UnityEngine;

namespace CollectBallsGame
{
    public class CollectPopupAllLevelsCompletedComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public GameObject PopupAllLevelsCompleted;

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
            if (_gameModel.CollectGameState.Value == CollectGameState.AllLevelsCompleted)
            {
                PopupAllLevelsCompleted.SetActive(true);
            }
        }
    }
}