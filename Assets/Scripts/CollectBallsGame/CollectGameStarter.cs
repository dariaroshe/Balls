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
            CollectGameScene.CollectPopupGameOverComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.ScoreHealthBarComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectPopupLevelCompletedComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.RandomSpawnerBallsComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.MovingBasketComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectPopupPauseComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectButtonNextLevelComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectButtonReturnComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectButtonContinueComponent.Initialize(gameModel, CollectGameScene);

            for (int i = 0; i < CollectGameScene.CollectButtonMenuComponent.Length; i++)
            {
                CollectGameScene.CollectButtonMenuComponent[i].Initialize(gameModel, CollectGameScene);
            }
        }
    }
}