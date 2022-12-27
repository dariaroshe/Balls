using UnityEngine;

namespace Game
{
    public abstract class GameComponent : MonoBehaviour
    {
        public abstract void Initialize(GameModel gameModel, GameScene gameScene);
    }
}