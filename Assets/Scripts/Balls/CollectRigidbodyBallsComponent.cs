using System;
using CollectBallsGame;
using Service;
using UnityEngine;

namespace Balls
{
    public class CollectRigidbodyBallsComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;
        
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        }

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.CollectGameState.Changed += OnGameStateChanched;
        }

        private void OnDestroy()
        {
            _gameModel.CollectGameState.Changed -= OnGameStateChanched;
        }

        private void OnGameStateChanched()
        {
            if (_gameModel.CollectGameState.Value == CollectGameState.Paused)
            {
                _rigidbody2D.bodyType = RigidbodyType2D.Static;
            }
            else if (_gameModel.CollectGameState.Value == CollectGameState.Playing)
            {
                _rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }
}