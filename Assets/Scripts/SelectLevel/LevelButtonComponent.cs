using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SelectLevel
{
    public class LevelButtonComponent : MonoBehaviour
    {
        [SerializeField] private TextLevelButtonsComponent _textLevelButton;
        [SerializeField] private ClickLevelButtonComponent _clickLevelButton;
        [SerializeField] private BlockLevelButtonComponent _blockLevelButton;

        private SelectLevelModel _selectLevelModel;
        private SelectLevelScene _selectLevelScene;
        private int _levelIndex;

        public void Initialize(SelectLevelModel selectLevelModel, SelectLevelScene selectLevelScene, int levelIndex)
        {
            _selectLevelModel = selectLevelModel;
            _selectLevelScene = selectLevelScene;
            _levelIndex = levelIndex;
            
            _textLevelButton.Initialize(_selectLevelModel, _selectLevelScene, _levelIndex);
            _clickLevelButton.Initialize(_selectLevelModel, _selectLevelScene, _levelIndex);
            _blockLevelButton.Initialize(_selectLevelModel, _selectLevelScene, _levelIndex);
        }
    }
}