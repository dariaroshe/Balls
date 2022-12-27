using Balls;
using TMPro;
using UnityEngine;

namespace CollectBallsGame
{
    public class CollectScoreTextComponent : CollectGameComponent
    {
        [SerializeField] private TextMeshPro _text;
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
            _text.text = _gameModel.Score.Value.ToString();
        }
    }
}