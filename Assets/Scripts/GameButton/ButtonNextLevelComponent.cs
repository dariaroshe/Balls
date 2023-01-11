using CollectBallsGame;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameButton
{
    public class ButtonNextLevelComponent : GameComponent
    {
        [SerializeField] private Button _buttonNextLevel;
        
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _buttonNextLevel.onClick.AddListener(OnButtonClick); 
        }

        private void OnDestroy()
        {
            _buttonNextLevel.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            SceneManager.LoadScene(_gameScene.NextLevel);
        }
    }
}