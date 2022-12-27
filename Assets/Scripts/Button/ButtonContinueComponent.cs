using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CollectBallsGame
{
    public class ButtonContinueComponent : CollectGameComponent
    {
        [SerializeField] private Button _buttonContinue;

        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
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