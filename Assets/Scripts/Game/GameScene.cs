using Balls;
using Basket;
using GameButtons;
using GamePopup;
using Levels;
using TMPro;
using UnityEngine;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public BasketTriggerComponent BasketTriggerComponent;
        public FailedBallTriggerComponent[] FailedBallTriggerComponent;
        public ScoreTextComponent ScoreText;

        public RigidbodyBallsComponent[] RigidbodyBallsComponent;
        
        public PopupGameOverComponent PopupGameOverComponent;
        public PopupLevelCompletedComponent PopupLevelCompletedComponent;
        public PopupPauseComponent PopupPauseComponent;
        public PopupAllLevelsCompletedComponent PopupAllLevelsCompletedComponent;
        
        public ButtonNextLevelComponent ButtonNextLevelComponent;
        public ButtonReturnComponent ButtonReturnComponent;
        public ButtonContinueComponent ButtonContinueComponent;
        public ButtonMenuComponent[] ButtonMenuComponent;

        public GameSaveComponent GameSaveComponent;
        public GameLevelCompletedComponent GameLevelCompletedComponent;
        public GameOverComponent GameOverComponent;
        
        public int FailedBallsLooseValue;
        public int MinAmountCollectBalls;
        public LevelsData LevelsData;
    }
}