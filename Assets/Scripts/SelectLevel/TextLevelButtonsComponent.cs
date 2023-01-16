using System;
using Levels;
using TMPro;
using UnityEngine;

namespace SelectLevel
{
    public class TextLevelButtonsComponent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textLevelButton;

        public LevelsData LevelsData;

        private void Start()
        {
            ChangedTextButton();
        }

        private void ChangedTextButton()
        {
            for (int i = 0; i < LevelsData.LevelNames.Count; i++)
            {
                var numberLevel = i + 1;
                _textLevelButton.text = numberLevel.ToString();
            }
        }
    }
}