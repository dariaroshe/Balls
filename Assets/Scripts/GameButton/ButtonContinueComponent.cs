using CollectBallsGame;
using Game;
using Service;
using UnityEngine;
using UnityEngine.UI;

namespace GameButton
{
    public class ButtonContinueComponent : GameComponent
    {
        [SerializeField] private Button _buttonContinue;

        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _buttonContinue.onClick.AddListener(OnButtonClick); 
        }

        private void OnDestroy()
        {
            _buttonContinue.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            if (_gameModel.GameState.Value == GameState.Paused)
            {
                var popupPause = _gameScene.PopupPauseComponent.PopupPause;
                popupPause.SetActive(false);
                _gameModel.GameState.Value = GameState.Playing;
            }
        }
    }
}