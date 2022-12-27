using Balls;
using Game;
using UnityEngine;

namespace CollectBallsGame
{
    public class CollectGameStarter : MonoBehaviour
    {
        public CollectGameScene CollectGameScene;
        
        private void Awake()
        {
            var gameModel = new CollectGameModel();

            gameModel.FailedBalls.Value = CollectGameScene.FailedBallsLooseValue;
            
            CollectGameScene.MovingBasketTriggerComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.ScoreTextComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.FailedBallTriggerComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.PopupGameOverComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.ScoreHealthBarComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.PopupLevelCompletedComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.RandomSpawnerBallsComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.MovingBasketComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.PopupPauseComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.ButtonNextLevelComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.ButtonReturnComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.ButtonContinueComponent.Initialize(gameModel, CollectGameScene);

            for (int i = 0; i < CollectGameScene.ButtonMenuComponent.Length; i++)
            {
                CollectGameScene.ButtonMenuComponent[i].Initialize(gameModel, CollectGameScene);
            }
        }
    }
}