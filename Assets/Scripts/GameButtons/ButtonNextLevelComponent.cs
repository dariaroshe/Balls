using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameButtons
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
            var nextLevel = _gameModel.CurrentLevel + 1;
            var nextLevelName = _gameScene.LevelsData.LevelNames[nextLevel];
            SceneManager.LoadScene(nextLevelName);
        }
    }
}