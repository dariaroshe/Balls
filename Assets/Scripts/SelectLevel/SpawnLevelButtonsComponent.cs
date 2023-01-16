using System;
using Levels;
using UnityEngine;
using UnityEngine.UI;

namespace SelectLevel
{
    public class SpawnLevelButtonsComponent : SelectLevelComponent
    {
        [SerializeField] private Button _buttonLevel;
        [SerializeField] private Transform _gridTransform;
       
        private SelectLevelModel _selectLevelModel;
        private SelectLevelScene _selectLevelScene;

        public override void Initialize(SelectLevelModel selectLevelModel, SelectLevelScene selectLevelScene)
        {
            _selectLevelModel = selectLevelModel;
            _selectLevelScene = selectLevelScene;
        }
        
        private void Start()
        {
            SpawnLevelButtons();
        }

        private void SpawnLevelButtons()
        {
            for (int i = 0; i < _selectLevelScene.LevelsData.LevelNames.Count; i++)
            {
                Instantiate(_buttonLevel, _gridTransform);
                
            }
        }
    }
}