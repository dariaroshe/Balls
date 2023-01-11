using System;
using Service;
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
                if (_gameModel.CollectGameState.Value == CollectGameState.Playing)
                {
                    PopupPause.SetActive(true);
                    _gameModel.CollectGameState.Value = CollectGameState.Paused;
                }
            }
        }
    }
}