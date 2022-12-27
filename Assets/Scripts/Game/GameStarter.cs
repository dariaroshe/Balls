using System;
using UnityEngine;

namespace Game
{
    public class GameStarter : MonoBehaviour
    {
        public GameScene GameScene;
        
        private void Start()
        {
            var gameModel = new GameModel();
            
            GameScene.BasketTriggerComponent.Initialize(gameModel, GameScene);
            GameScene.ScoreText.Initialize(gameModel, GameScene);
            GameScene.GameOverComponent.Initialize(gameModel, GameScene);

            for (int i = 0; i < GameScene.FailedBallTriggerComponent.Length; i++)
            {
                GameScene.FailedBallTriggerComponent[i].Initialize(gameModel, GameScene);
            }
        }
    }
}