using System;
using Levels;
using TMPro;
using UnityEngine;

namespace SelectLevel
{
    public class TextLevelButtonsComponent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textLevelButton;
        
        private SelectLevelModel _selectLevelModel;
        private SelectLevelScene _selectLevelScene;
        private int _levelIndex;

        public void Initialize(SelectLevelModel selectLevelModel, SelectLevelScene selectLevelScene, int levelIndex)
        {
            _selectLevelModel = selectLevelModel;
            _selectLevelScene = selectLevelScene;
            _levelIndex = levelIndex;
            
            ChangedTextButton();
        }

        private void ChangedTextButton()
        {
            _textLevelButton.text = (_levelIndex + 1).ToString();
        }
    }
}