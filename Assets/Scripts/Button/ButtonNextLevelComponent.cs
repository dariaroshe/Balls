using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CollectBallsGame
{
    public class ButtonNextLevelComponent : CollectGameComponent
    {
        [SerializeField] private Button _buttonNextLevel;
        [SerializeField] private string _nextLevel;
        
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
            SceneManager.LoadScene(_nextLevel);
        }
    }
}