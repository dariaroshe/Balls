using CollectBallsGame;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CollectButtons
{
    public class CollectButtonNextLevelComponent : CollectGameComponent
    {
        [SerializeField] private Button _buttonNextLevel;
        
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
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