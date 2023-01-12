using Balls;
using Basket;
using CollectButtons;
using Levels;
using UnityEngine;

namespace CollectBallsGame
{
    public class CollectGameScene : MonoBehaviour
    {
        public MovingBasketTriggerComponent MovingBasketTriggerComponent;
        public CollectFailedBallTriggerComponent FailedBallTriggerComponent;
        
        public CollectScoreHealthBarComponent ScoreHealthBarComponent;
        public MovingBasketComponent MovingBasketComponent;
        public CollectScoreTextComponent ScoreTextComponent;

        public RandomSpawnerBallsComponent RandomSpawnerBallsComponent;
        public RandomSpawnerColorBallsComponent SpawnerColorBallsComponent;
        
        public CollectPopupGameOverComponent CollectPopupGameOverComponent;
        public CollectPopupLevelCompletedComponent CollectPopupLevelCompletedComponent;
        public CollectPopupPauseComponent CollectPopupPauseComponent;
        
        public CollectButtonNextLevelComponent CollectButtonNextLevelComponent;
        public CollectButtonReturnComponent CollectButtonReturnComponent;
        public CollectButtonContinueComponent CollectButtonContinueComponent;
        public CollectButtonMenuComponent[] CollectButtonMenuComponent;

        public CollectGameSaveComponent CollectGameSaveComponent;
        public CollectLevelCompleted CollectLevelCompleted;
        
        public int FailedBallsLooseValue;
        public int TotalCollectBalls;
        public LevelsData LevelsData;
    }
}