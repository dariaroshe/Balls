namespace Game
{
    public class GameLevelCompletedComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

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
            var isLastLevel = _gameModel.CurrentLevel == _gameScene.LevelsData.LevelNames.Count - 1;
            
            if (_gameModel.Score.Value >= _gameScene.MinAmountCollectBalls && !isLastLevel)
            {
                _gameModel.GameState.Value = GameState.LevelCompleted;
            }
            else if (_gameModel.Score.Value >= _gameScene.MinAmountCollectBalls && isLastLevel)
            {
                _gameModel.GameState.Value = GameState.AllLevelsCompleted;
            }
        }
    }
}