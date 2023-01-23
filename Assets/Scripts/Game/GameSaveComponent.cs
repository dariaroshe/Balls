using UnityEngine;

namespace Game
{
    public class GameSaveComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.GameState.Changed += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed -= OnGameStateChanged;
        }

        private void OnGameStateChanged()
        {
            var levelCompleted = PlayerPrefs.GetInt("CurrentLevel", 0);
            
            if (levelCompleted >= _gameModel.CurrentLevel)
            {
                return;
            }

            var gameState = _gameModel.GameState.Value;
            
            if (gameState == GameState.LevelCompleted || gameState == GameState.AllLevelsCompleted)
            {
                var nextLevel = _gameScene.LevelsData.GetNextLevel(_gameModel.CurrentLevel);
                PlayerPrefs.SetInt("CurrentLevel", nextLevel);
            }
        }
    }
}