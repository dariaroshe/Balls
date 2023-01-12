using MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainMenuButtons
{
    public class ButtonSelectLevelComponent : MainMenuComponent
    {
        [SerializeField] private Button _buttonSelectLevel;

        private MainMenuModel _menuModel;
        private MainMenuScene _menuScene;

        public override void Initialize(MainMenuModel menuModel, MainMenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;
            
            _buttonSelectLevel.onClick.AddListener(OnButtonClick); 
        }

        private void OnDestroy()
        {
            _buttonSelectLevel.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            SceneManager.LoadScene("SelectLevel");
        }
    }
}