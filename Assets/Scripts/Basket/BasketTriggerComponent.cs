using UnityEngine;

namespace Game
{
    public class BasketTriggerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            _gameModel.Score.Value++;
            Destroy(other.gameObject);
        }
    }
}