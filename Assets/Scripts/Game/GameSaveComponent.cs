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
            if (_gameModel.GameState.Value == GameState.LevelCompleted || _gameModel.GameState.Value == GameState.AllLevelsCompleted)
            {
                Debug.Log(_gameModel.CurrentLevel);
                PlayerPrefs.SetInt("CurrentLevel", _gameModel.CurrentLevel);
            }
        }
    }
}