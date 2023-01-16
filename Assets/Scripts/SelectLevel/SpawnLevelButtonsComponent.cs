using System;
using Levels;
using UnityEngine;
using UnityEngine.UI;

namespace SelectLevel
{
    public class SpawnLevelButtonsComponent : SelectLevelComponent
    {
        [SerializeField] private TextLevelButtonsComponent _buttonLevel;
        [SerializeField] private Transform _gridTransform;
       
        private SelectLevelModel _selectLevelModel;
        private SelectLevelScene _selectLevelScene;

        public override void Initialize(SelectLevelModel selectLevelModel, SelectLevelScene selectLevelScene)
        {
            _selectLevelModel = selectLevelModel;
            _selectLevelScene = selectLevelScene;
            
            SpawnLevelButtons();
        }
        
        private void SpawnLevelButtons()
        {
            for (int i = 0; i < _selectLevelScene.LevelsData.LevelNames.Count; i++)
            {
                var button = Instantiate(_buttonLevel, _gridTransform);
                button.Initialize(_selectLevelModel, _selectLevelScene, i);
            }
        }
    }
}