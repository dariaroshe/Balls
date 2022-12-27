using System;
using UnityEngine;

namespace CollectBallsGame
{
    public class CollectPopupPauseComponent : CollectGameComponent
    {
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public GameObject PopupPause;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
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