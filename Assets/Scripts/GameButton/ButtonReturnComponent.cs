using CollectBallsGame;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameButton
{
    public class ButtonReturnComponent : GameComponent
    {
        [SerializeField] private Button _buttonReturn;
        [SerializeField] private string _returnLevel;

        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
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