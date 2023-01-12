using UnityEngine;

namespace MainMenu
{
    public abstract class MainMenuComponent : MonoBehaviour
    {
        public abstract void Initialize(MainMenuModel gameModel, MainMenuScene gameScene);
    }
}