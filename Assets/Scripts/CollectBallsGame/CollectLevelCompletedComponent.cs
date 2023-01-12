namespace CollectBallsGame
{
    public class CollectLevelCompletedComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
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

            if (_gameModel.Score.Value == _gameScene.TotalCollectBalls && !isLastLevel)
            {
                _gameModel.CollectGameState.Value = CollectGameState.LevelCompleted;
            }
            else if (_gameModel.Score.Value == _gameScene.TotalCollectBalls && isLastLevel)
            {
                _gameModel.CollectGameState.Value = CollectGameState.AllLevelsCompleted;
            }
        }
    }
}