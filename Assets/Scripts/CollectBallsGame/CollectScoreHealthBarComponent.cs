using Balls;
using TMPro;
using UnityEngine;

namespace CollectBallsGame
{
    public class CollectScoreHealthBarComponent : CollectGameComponent
    {
        [SerializeField] private TextMeshPro _text;
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _text.text = _gameModel.FailedBalls.Value.ToString();

            _gameModel.FailedBalls.Changed += OnScoreChanged;
        }

        private void OnDestroy()
        {
            _gameModel.FailedBalls.Changed -= OnScoreChanged;
        }

        private void OnScoreChanged()
        {
            _text.text = _gameModel.FailedBalls.Value.ToString();
        }
    }
}