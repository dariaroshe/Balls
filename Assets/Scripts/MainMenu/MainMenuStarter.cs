using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class MainMenuStarter : MonoBehaviour
    {
        public MainMenuScene MenuScene;

        private void Start()
        {
            var mainMenuModel = new MainMenuModel();
            
            MenuScene.ButtonPlayComponent.Initialize(mainMenuModel, MenuScene);
            MenuScene.ButtonSelectLevelComponent.Initialize(mainMenuModel, MenuScene);
        }
    }
}