using Balls;
using Basket;
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
        
        public CollectPopupGameOverComponent PopupGameOverComponent;
        public CollectPopupLevelCompletedComponent PopupLevelCompletedComponent;
        public CollectPopupPauseComponent PopupPauseComponent;

        public ButtonNextLevelComponent ButtonNextLevelComponent;
        public ButtonReturnComponent ButtonReturnComponent;
        public ButtonContinueComponent ButtonContinueComponent;
        public ButtonMenuComponent[] ButtonMenuComponent;
        
        public int FailedBallsLooseValue;
        public int TotalCollectBalls;
    }
}