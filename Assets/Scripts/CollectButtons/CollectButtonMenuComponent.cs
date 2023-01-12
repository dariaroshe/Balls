using CollectBallsGame;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CollectButtons
{
    public class CollectButtonMenuComponent : CollectGameComponent
    {
        [SerializeField] private Button _buttonMenu;

        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _buttonMenu.onClick.AddListener(OnButtonClick); 
        }

        private void OnDestroy()
        {
            _buttonMenu.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}