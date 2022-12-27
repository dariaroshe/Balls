using Balls;
using Basket;
using TMPro;
using UnityEngine;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public BasketTriggerComponent BasketTriggerComponent;
        public FailedBallTriggerComponent[] FailedBallTriggerComponent;
        public ScoreTextComponent ScoreText;
        public GameOverComponent GameOverComponent;
        
        public int FailedBallsLooseValue;
    }
}