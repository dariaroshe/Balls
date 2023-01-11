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
            GameScene.PopupGameOverComponent.Initialize(gameModel, GameScene);
            GameScene.PopupLevelCompletedComponent.Initialize(gameModel, GameScene);
            GameScene.PopupPauseComponent.Initialize(gameModel, GameScene);
            GameScene.ButtonNextLevelComponent.Initialize(gameModel, GameScene);
            GameScene.ButtonReturnComponent.Initialize(gameModel, GameScene);
            GameScene.ButtonContinueComponent.Initialize(gameModel, GameScene);

            for (int i = 0; i < GameScene.RigidbodyBallsComponent.Length; i++)
            {
                GameScene.RigidbodyBallsComponent[i].Initialize(gameModel, GameScene);
            }

            for (int i = 0; i < GameScene.FailedBallTriggerComponent.Length; i++)
            {
                GameScene.FailedBallTriggerComponent[i].Initialize(gameModel, GameScene);
            }

            for (int i = 0; i < GameScene.ButtonMenuComponent.Length; i++)
            {
                GameScene.ButtonMenuComponent[i].Initialize(gameModel, GameScene);
            }
        }
    }
}