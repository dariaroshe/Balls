using System;
using UnityEngine;

namespace Game
{
    public class FailedBallTriggerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (_gameModel.GameState.Value == GameState.Playing)
            {
                _gameModel.FailedBalls.Value++;
            }
            
            Destroy(other.gameObject);
        }
    }
}