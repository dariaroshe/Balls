using System;
using Levels;
using UnityEngine;
using UnityEngine.UI;

namespace SelectLevel
{
    public class SpawnLevelButtonsComponent : MonoBehaviour
    {
        [SerializeField] private Button _buttonLevel;
        [SerializeField] private Transform _gridTransform;

        public LevelsData LevelsData;

        private void Start()
        {
            SpawnLevelButtons();
        }

        private void SpawnLevelButtons()
        {
            for (int i = 0; i < LevelsData.LevelNames.Count; i++)
            {
                Instantiate(_buttonLevel, _gridTransform);
            }
        }
    }
}