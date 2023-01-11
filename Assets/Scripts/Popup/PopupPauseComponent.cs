using CollectBallsGame;
using Game;
using Service;
using UnityEngine;

namespace Popup
{
    public class PopupPauseComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public GameObject PopupPause;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                if (_gameModel.GameState.Value == GameState.Playing)
                {
                    PopupPause.SetActive(true);
                    _gameModel.GameState.Value = GameState.Paused;
                }
            }
        }
    }
}