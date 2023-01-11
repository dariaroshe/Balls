using CollectBallsGame;
using Service;
using UnityEngine;
using UnityEngine.UI;

namespace CollectButton
{
    public class CollectButtonContinueComponent : CollectGameComponent
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
            if (_gameModel.CollectGameState.Value == CollectGameState.Paused)
            {
                var popupPause = _gameScene.CollectPopupPauseComponent.PopupPause;
                popupPause.SetActive(false);
                _gameModel.CollectGameState.Value = CollectGameState.Playing;
            }
        }
    }
}