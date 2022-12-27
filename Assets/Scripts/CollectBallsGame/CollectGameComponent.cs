using Balls;
using Game;
using UnityEngine;

namespace CollectBallsGame
{
    public abstract class CollectGameComponent : MonoBehaviour
    {
        public abstract void Initialize(CollectGameModel gameModel, CollectGameScene gameScene);
    }
}