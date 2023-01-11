using UnityEngine;

namespace CollectBallsGame
{
    public class CollectGameSaveComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _gameModel.CollectGameState.Changed += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            _gameModel.CollectGameState.Changed -= OnGameStateChanged;
        }

        private void OnGameStateChanged()
        {
            if (_gameModel.CollectGameState.Value == CollectGameState.LevelCompleted)
            {
                PlayerPrefs.SetInt("CurrentLevel", _gameModel.CurrentLevel);
            }
        }
    }
}