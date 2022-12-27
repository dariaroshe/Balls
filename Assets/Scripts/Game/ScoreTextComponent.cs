using System;
using TMPro;
using UnityEngine;

namespace Game
{
    public class ScoreTextComponent : GameComponent
    {
        [SerializeField] private TextMeshPro _text;
        
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
            _text.text = _gameModel.Score.Value.ToString();
        }

        
    }
}