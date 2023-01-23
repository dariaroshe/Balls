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
            var levelCompleted = PlayerPrefs.GetInt("CurrentLevel", 0);
            
            if (levelCompleted >= _gameModel.CurrentLevel)
            {
                return;
            }

            var gameState = _gameModel.CollectGameState.Value;
            
            if (gameState == CollectGameState.LevelCompleted || gameState == CollectGameState.AllLevelsCompleted)
            {
                var nextLevel = _gameScene.LevelsData.GetNextLevel(_gameModel.CurrentLevel);
                PlayerPrefs.SetInt("CurrentLevel", nextLevel);
            }
        }
    }
}