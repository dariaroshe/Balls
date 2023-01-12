using Balls;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CollectBallsGame
{
    public class CollectGameStarter : MonoBehaviour
    {
        public CollectGameScene CollectGameScene;
        
        private void Awake()
        {
            var currentSceneName = SceneManager.GetActiveScene().name;
            var currentLevel = CollectGameScene.LevelsData.LevelNames.IndexOf(currentSceneName);
            
            var gameModel = new CollectGameModel(currentLevel);

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
            CollectGameScene.CollectGameSaveComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectLevelCompletedComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectPopupAllLevelsCompletedComponent.Initialize(gameModel, CollectGameScene);
            CollectGameScene.CollectGameOverComponent.Initialize(gameModel, CollectGameScene);

            for (int i = 0; i < CollectGameScene.CollectButtonMenuComponent.Length; i++)
            {
                CollectGameScene.CollectButtonMenuComponent[i].Initialize(gameModel, CollectGameScene);
            }
        }
    }
}