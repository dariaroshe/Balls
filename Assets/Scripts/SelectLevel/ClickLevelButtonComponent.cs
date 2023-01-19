using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SelectLevel
{
    public class ClickLevelButtonComponent : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private SelectLevelModel _selectLevelModel;
        private SelectLevelScene _selectLevelScene;
        private int _levelIndex;

        public void Initialize(SelectLevelModel selectLevelModel, SelectLevelScene selectLevelScene, int levelIndex)
        {
            _selectLevelModel = selectLevelModel;
            _selectLevelScene = selectLevelScene;
            _levelIndex = levelIndex;

            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            var levelCompleted = PlayerPrefs.GetInt("CurrentLevel", 0);

            if (_levelIndex <= levelCompleted)
            {
                SceneManager.LoadScene(_selectLevelScene.LevelsData.LevelNames[_levelIndex]);
            }
        }
    }
}