namespace CollectBallsGame
{
    public class CollectGameOverComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _gameModel.FailedBalls.Changed += OnFailedBallsChanged;
        }

        private void OnDestroy()
        {
            _gameModel.FailedBalls.Changed -= OnFailedBallsChanged;
        }

        private void OnFailedBallsChanged()
        {
            if (_gameModel.FailedBalls.Value == 0)
            {
                _gameModel.CollectGameState.Value = CollectGameState.GameOver;
            }
        }
    }
}