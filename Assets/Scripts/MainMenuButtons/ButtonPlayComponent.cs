using MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainMenuButtons
{
    public class ButtonPlayComponent : MainMenuComponent
    {
        [SerializeField] private Button _buttonPlay;

        private MainMenuModel _menuModel;
        private MainMenuScene _menuScene;

        public override void Initialize(MainMenuModel menuModel, MainMenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;

            _buttonPlay.onClick.AddListener(OnButtonClick);
        }

        private void OnDestroy()
        {
            _buttonPlay.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            var currentLevel = PlayerPrefs.GetInt("CurrentLevel", 0);
            var currentLevelName = _menuScene.LevelsData.LevelNames[currentLevel];
            SceneManager.LoadScene(currentLevelName);
        }
    }
}