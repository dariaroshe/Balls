using System;
using Balls;
using CollectBallsGame;
using Game;
using UnityEngine;

namespace Basket
{
    public class MovingBasketTriggerComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            var ballComponent = other.GetComponent<BallComponent>();
            var colorIndex = _gameScene.SpawnerColorBallsComponent.RandomColorBall;
            
            if (colorIndex == ballComponent.Type && _gameModel.GameState.Value == GameState.Playing)
            {
                _gameModel.Score.Value++;
            }
            else if (colorIndex != ballComponent.Type && _gameModel.GameState.Value == GameState.Playing)
            {
                _gameModel.FailedBalls.Value--;
            }
            
            Destroy(other.gameObject);
        }
    }
}