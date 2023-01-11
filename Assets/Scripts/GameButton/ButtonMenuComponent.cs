using CollectBallsGame;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameButton
{
    public class ButtonMenuComponent : GameComponent
    {
        [SerializeField] private Button _buttonMenu;

        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
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