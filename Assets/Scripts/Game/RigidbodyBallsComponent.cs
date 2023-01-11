using CollectBallsGame;
using UnityEngine;

namespace Game
{
    public class RigidbodyBallsComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        }

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.GameState.Changed += OnGameStateChanched;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed -= OnGameStateChanched;
        }

        private void OnGameStateChanched()
        {
            if (_gameModel.GameState.Value == GameState.Paused)
            {
                _rigidbody2D.bodyType = RigidbodyType2D.Static;
            }
            else if (_gameModel.GameState.Value == GameState.Playing)
            {
                _rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }
}