using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CollectBallsGame
{
    public class ButtonReturnComponent : CollectGameComponent
    {
        [SerializeField] private Button _buttonReturn;
        [SerializeField] private string _returnLevel;
        
        private CollectGameModel _gameModel;
        private CollectGameScene _gameScene;

        public override void Initialize(CollectGameModel gameModel, CollectGameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _buttonReturn.onClick.AddListener(OnButtonClick); 
        }

        private void OnDestroy()
        {
            _buttonReturn.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            SceneManager.LoadScene(_returnLevel);
        }
    }
}