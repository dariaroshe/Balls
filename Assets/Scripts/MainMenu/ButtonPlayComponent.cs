using Game;
using MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameButton
{
    public class ButtonPlayComponent : MonoBehaviour
    {
        [SerializeField] private Button _buttonPlay;

        private MainMenuModel _menuModel;
        private MainMenuScene _menuScene;

        public void Initialize(MainMenuModel menuModel, MainMenuScene menuScene)
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